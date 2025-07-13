using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTester
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource? _cts;
        private System.Windows.Forms.Timer _autoPingTimer;

        private readonly string logFilePath = "ping_log.txt";
        private readonly string csvFilePath = "ping_results.csv";

        public Form1()
        {
            InitializeComponent();
            comboHosts.SelectedIndex = 0;
            btnCancel.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _autoPingTimer = new System.Windows.Forms.Timer();
            _autoPingTimer.Interval = 10000;
            _autoPingTimer.Tick += AutoPingTimer_Tick;
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            await StartPingTestAsync();
        }

        private async Task StartPingTestAsync()
        {
            btnPing.Enabled = false;
            btnCancel.Enabled = true;
            btnClear.Enabled = false;
            txtOutput.Clear();

            string customHost = txtCustom.Text.Trim();
            int pingCount = (int)numCount.Value;

            string[] defaultHosts = { "8.8.8.8", "1.1.1.1", "9.9.9.9", "208.67.222.222", "8.8.4.4" };
            string[] hostsToPing;

            if (!string.IsNullOrEmpty(customHost))
            {
                hostsToPing = new string[] { customHost };
            }
            else if (comboHosts.SelectedIndex == 0)
            {
                hostsToPing = defaultHosts;
            }
            else
            {
                var selected = comboHosts.SelectedItem?.ToString();
                hostsToPing = !string.IsNullOrEmpty(selected) ? new string[] { selected } : defaultHosts;
            }

            progressBar.Value = 0;
            progressBar.Maximum = hostsToPing.Length * pingCount;

            _cts = new CancellationTokenSource();

            try
            {
                File.AppendAllText(logFilePath, $"--- Test Ping rozpoczęty: {DateTime.Now} ---\n");
            }
            catch (Exception ex)
            {
                AppendColoredText($"Błąd pliku logu: {ex.Message}\n", Color.OrangeRed);
            }

            try
            {
                int current = 0;
                foreach (var host in hostsToPing)
                {
                    if (_cts.IsCancellationRequested) break;

                    AppendColoredText($"Pinging {host}...\n", Color.FromArgb(220, 220, 220));
                    await PingHostAsync(host, pingCount, () =>
                    {
                        current++;
                        if (progressBar.InvokeRequired)
                            progressBar.Invoke(new Action(() => progressBar.Value = current));
                        else
                            progressBar.Value = current;
                    }, _cts.Token);
                }
            }
            catch (OperationCanceledException)
            {
                AppendColoredText("Anulowano przez użytkownika.\n", Color.OrangeRed);
            }
            finally
            {
                btnPing.Enabled = true;
                btnCancel.Enabled = false;
                btnClear.Enabled = true;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private async void AutoPingTimer_Tick(object? sender, EventArgs e)
        {
            if (btnPing.Enabled)
            {
                await StartPingTestAsync();
            }
        }

        private async Task PingHostAsync(string host, int count, Action progress, CancellationToken token)
        {
            using var ping = new Ping();
            int successCount = 0;
            long totalTime = 0;
            long minTime = long.MaxValue;
            long maxTime = 0;

            for (int i = 0; i < count; i++)
            {
                if (token.IsCancellationRequested) return;
                try
                {
                    PingReply reply = await ping.SendPingAsync(host, 1000);
                    if (reply.Status == IPStatus.Success)
                    {
                        successCount++;
                        totalTime += reply.RoundtripTime;
                        minTime = Math.Min(minTime, reply.RoundtripTime);
                        maxTime = Math.Max(maxTime, reply.RoundtripTime);
                        AppendColoredText($"Odpowiedź z {reply.Address}: czas={reply.RoundtripTime}ms\n", Color.LawnGreen);
                        Log($"{DateTime.Now}: Odpowiedź z {host}, Czas={reply.RoundtripTime}ms");
                        AppendCsv($"{DateTime.Now:O},{host},Success,{reply.RoundtripTime}");
                    }
                    else
                    {
                        AppendColoredText($"Błąd: {reply.Status}\n", Color.Red);
                        Log($"{DateTime.Now}: Błąd pingowania {host}, Status: {reply.Status}");
                        AppendCsv($"{DateTime.Now:O},{host},Fail,{reply.Status}");
                    }
                }
                catch (PingException ex)
                {
                    AppendColoredText($"Błąd Ping: {ex.Message}\n", Color.Red);
                    Log($"{DateTime.Now}: Błąd Ping {host}: {ex.Message}");
                    AppendCsv($"{DateTime.Now:O},{host},Error,{ex.Message}");
                }
                progress?.Invoke();
                await Task.Delay(300, token);
            }

            if (successCount > 0)
            {
                AppendColoredText($"Statystyki dla {host}: Śr. {totalTime / successCount}ms, Min. {minTime}ms, Max. {maxTime}ms\n", Color.Cyan);
            }
            else
            {
                AppendColoredText($"Brak odpowiedzi od {host}.\n", Color.DarkGray);
            }
        }

        private async void btnSpeedTest_Click(object sender, EventArgs e)
        {
            btnSpeedTest.Enabled = false;
            lblDownload.Text = "Download: ...";
            lblUpload.Text = "Upload: ...";
            lblPing.Text = "Ping: ...";

            string testHost = "ftp.icm.edu.pl";
            string downloadUrl = "http://ftp.icm.edu.pl/pub/Linux/distributions/archlinux/iso/latest/archlinux-x86_64.iso";

            // <<< POPRAWKA: Dodajemy \n\n na początku, aby oddzielić test od poprzednich wpisów.
            AppendColoredText("\n\n⚡ Rozpoczynam test prędkości do ", Color.Gold);
            AppendColoredText(testHost + "...\n\n", Color.Cyan);

            // Ping do serwera testowego
            try
            {
                using var ping = new Ping();
                var reply = await ping.SendPingAsync(testHost, 2000);
                if (reply.Status == IPStatus.Success)
                {
                    lblPing.Text = $"Ping: {reply.RoundtripTime} ms";
                    AppendColoredText("   [PING]\n", Color.WhiteSmoke);
                    AppendColoredText($"   └─ Serwer: {testHost}, Czas: ", Color.Gray);
                    AppendColoredText($"{reply.RoundtripTime}ms\n\n", Color.LawnGreen);
                }
                else
                {
                    lblPing.Text = "Ping: błąd";
                }
            }
            catch { lblPing.Text = "Ping: błąd"; }

            var handler = new HttpClientHandler { ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true };
            using var httpClient = new HttpClient(handler);
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");

            // Test pobierania
            try
            {
                AppendColoredText("   [POBIERANIE]\n", Color.WhiteSmoke);
                var sw = Stopwatch.StartNew();
                HttpResponseMessage response = await httpClient.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();

                long totalBytesRead = 0;
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    byte[] buffer = new byte[8192];
                    int bytesRead;
                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytesRead += bytesRead;
                    }
                }
                sw.Stop();

                double seconds = sw.Elapsed.TotalSeconds;
                double mbits = (totalBytesRead * 8.0) / (seconds * 1_000_000);
                lblDownload.Text = $"Download: {mbits:F2} Mbit/s";

                AppendColoredText($"   ├─ Prędkość: ", Color.Gray);
                AppendColoredText($"{mbits:F2} Mbit/s\n", Color.Gold);
                AppendColoredText($"   ├─ Rozmiar:  ", Color.Gray);
                AppendColoredText($"{totalBytesRead / 1024.0 / 1024.0:F2} MB\n", Color.WhiteSmoke);
                AppendColoredText($"   └─ Czas:     ", Color.Gray);
                AppendColoredText($"{seconds:F2} s\n\n", Color.WhiteSmoke);
            }
            catch (Exception ex)
            {
                lblDownload.Text = "Download: błąd";
                AppendColoredText($"   └─ Błąd pobierania: {ex.Message}\n\n", Color.OrangeRed);
            }

            // Test wysyłania
            try
            {
                AppendColoredText("   [WYSYŁANIE]\n", Color.WhiteSmoke);
                string uploadUrl = "https://httpbin.org/post";
                byte[] uploadData = new byte[5 * 1024 * 1024];
                new Random().NextBytes(uploadData);
                using var content = new ByteArrayContent(uploadData);

                var sw = Stopwatch.StartNew();
                await httpClient.PostAsync(uploadUrl, content);
                sw.Stop();

                double upSeconds = sw.Elapsed.TotalSeconds;
                double upMbits = (uploadData.Length * 8.0) / (upSeconds * 1_000_000);
                lblUpload.Text = $"Upload: {upMbits:F2} Mbit/s";

                AppendColoredText($"   ├─ Prędkość: ", Color.Gray);
                AppendColoredText($"{upMbits:F2} Mbit/s\n", Color.DeepSkyBlue);
                AppendColoredText($"   ├─ Rozmiar:  ", Color.Gray);
                AppendColoredText($"{uploadData.Length / 1024.0 / 1024.0:F2} MB\n", Color.WhiteSmoke);
                AppendColoredText($"   └─ Czas:     ", Color.Gray);
                AppendColoredText($"{upSeconds:F2} s\n\n", Color.WhiteSmoke);
            }
            catch (Exception ex)
            {
                lblUpload.Text = "Upload: błąd";
                AppendColoredText($"   └─ Błąd wysyłania: {ex.Message}\n\n", Color.OrangeRed);
            }

            AppendColoredText("----------------------------------------\n", Color.FromArgb(63, 63, 70));
            btnSpeedTest.Enabled = true;
        }

        private void AppendColoredText(string text, Color color)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new Action(() => AppendColoredText(text, color)));
                return;
            }
            txtOutput.SelectionStart = txtOutput.TextLength;
            txtOutput.SelectionLength = 0;
            txtOutput.SelectionColor = color;
            txtOutput.AppendText(text);
            txtOutput.SelectionColor = txtOutput.ForeColor;
            txtOutput.ScrollToCaret();
        }

        private void Log(string line)
        {
            try { File.AppendAllText(logFilePath, line + Environment.NewLine); }
            catch { /* Ignoruj błędy zapisu */ }
        }

        private void AppendCsv(string line)
        {
            try { File.AppendAllText(csvFilePath, line + Environment.NewLine); }
            catch { /* Ignoruj błędy zapisu */ }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
            _autoPingTimer?.Stop();
            if (chkAutoPing.Checked) { chkAutoPing.Checked = false; }
        }

        private void chkAutoPing_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoPing.Checked)
            {
                if (!btnPing.Enabled)
                {
                    chkAutoPing.Checked = false;
                    return;
                }
                _autoPingTimer.Start();
                AutoPingTimer_Tick(this, EventArgs.Empty);
            }
            else
            {
                _autoPingTimer.Stop();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => txtOutput.Clear();
        private void btnOpenLog_Click(object sender, EventArgs e) => OpenFile(logFilePath);
        private void btnOpenCsv_Click(object sender, EventArgs e) => OpenFile(csvFilePath);

        private void OpenFile(string path)
        {
            try
            {
                if (File.Exists(path))
                    Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                AppendColoredText($"Błąd otwarcia pliku: {ex.Message}\n", Color.OrangeRed);
            }
        }
    }
}