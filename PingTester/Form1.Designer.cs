namespace PingTester
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _cts?.Dispose();
                _autoPingTimer?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            var darkBg = System.Drawing.Color.FromArgb(28, 28, 28);
            var cardBg = System.Drawing.Color.FromArgb(45, 45, 48);
            var controlBg = System.Drawing.Color.FromArgb(63, 63, 70);
            var text = System.Drawing.Color.FromArgb(241, 241, 241);
            var textSubtle = System.Drawing.Color.FromArgb(150, 150, 150);
            var accent = System.Drawing.Color.FromArgb(0, 122, 204);

            this.components = new System.ComponentModel.Container();
            this.comboHosts = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkAutoPing = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.btnOpenCsv = new System.Windows.Forms.Button();
            this.btnSpeedTest = new System.Windows.Forms.Button();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblPing = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = darkBg;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.btnSpeedTest);
            this.Controls.Add(this.btnOpenCsv);
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkAutoPing);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.comboHosts);
            this.Controls.Add(this.txtOutput);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = text;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping & Net Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // 
            // comboHosts
            // 
            this.comboHosts.BackColor = controlBg;
            this.comboHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboHosts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboHosts.ForeColor = text;
            this.comboHosts.FormattingEnabled = true;
            this.comboHosts.Items.AddRange(new object[] { "Domyślne DNS", "8.8.8.8", "1.1.1.1", "9.9.9.9", "208.67.222.222", "8.8.4.4" });
            this.comboHosts.Location = new System.Drawing.Point(22, 23);
            this.comboHosts.Name = "comboHosts";
            this.comboHosts.Size = new System.Drawing.Size(150, 25);
            // 
            // txtCustom
            // 
            this.txtCustom.BackColor = controlBg;
            this.txtCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustom.ForeColor = text;
            this.txtCustom.Location = new System.Drawing.Point(182, 23);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(200, 25);
            this.txtCustom.PlaceholderText = "lub wpisz własny host...";
            // 
            // numCount
            // 
            this.numCount.BackColor = controlBg;
            this.numCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCount.ForeColor = text;
            this.numCount.Location = new System.Drawing.Point(392, 23);
            this.numCount.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(50, 25);
            this.numCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // btnPing
            // 
            this.btnPing.BackColor = accent;
            this.btnPing.FlatAppearance.BorderSize = 0;
            this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPing.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPing.Location = new System.Drawing.Point(452, 21);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(110, 30);
            this.btnPing.Text = "PING 🌐";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnSpeedTest
            // 
            this.btnSpeedTest.BackColor = accent;
            this.btnSpeedTest.FlatAppearance.BorderSize = 0;
            this.btnSpeedTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeedTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSpeedTest.Location = new System.Drawing.Point(588, 21);
            this.btnSpeedTest.Name = "btnSpeedTest";
            this.btnSpeedTest.Size = new System.Drawing.Size(212, 30);
            this.btnSpeedTest.Text = "SPEED TEST ⚡";
            this.btnSpeedTest.UseVisualStyleBackColor = false;
            this.btnSpeedTest.Click += new System.EventHandler(this.btnSpeedTest_Click);
            // 
            // chkAutoPing
            // 
            this.chkAutoPing.AutoSize = true;
            this.chkAutoPing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkAutoPing.Location = new System.Drawing.Point(24, 73);
            this.chkAutoPing.Name = "chkAutoPing";
            this.chkAutoPing.Size = new System.Drawing.Size(124, 19);
            this.chkAutoPing.Text = "Pinguj cyklicznie 🔄";
            this.chkAutoPing.UseVisualStyleBackColor = true;
            this.chkAutoPing.CheckedChanged += new System.EventHandler(this.chkAutoPing_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = controlBg;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClear.Location = new System.Drawing.Point(260, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 28);
            this.btnClear.Text = "Wyczyść 🗑️";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.BackColor = controlBg;
            this.btnOpenLog.FlatAppearance.BorderSize = 0;
            this.btnOpenLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnOpenLog.Location = new System.Drawing.Point(355, 68);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(100, 28);
            this.btnOpenLog.Text = "Otwórz Log 📝";
            this.btnOpenLog.UseVisualStyleBackColor = false;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // btnOpenCsv
            // 
            this.btnOpenCsv.BackColor = controlBg;
            this.btnOpenCsv.FlatAppearance.BorderSize = 0;
            this.btnOpenCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCsv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnOpenCsv.Location = new System.Drawing.Point(465, 68);
            this.btnOpenCsv.Name = "btnOpenCsv";
            this.btnOpenCsv.Size = new System.Drawing.Size(100, 28);
            this.btnOpenCsv.Text = "Otwórz CSV 📊";
            this.btnOpenCsv.UseVisualStyleBackColor = false;
            this.btnOpenCsv.Click += new System.EventHandler(this.btnOpenCsv_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(164, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.Text = "Anuluj 🛑";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDownload
            // 
            this.lblDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDownload.ForeColor = System.Drawing.Color.Gold;
            this.lblDownload.Location = new System.Drawing.Point(588, 62);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(212, 20);
            this.lblDownload.Text = "Download: -";
            // 
            // lblUpload
            // 
            this.lblUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpload.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUpload.Location = new System.Drawing.Point(588, 87);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(212, 20);
            this.lblUpload.Text = "Upload: -";
            // 
            // lblPing
            // 
            this.lblPing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPing.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPing.Location = new System.Drawing.Point(588, 112);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(212, 20);
            this.lblPing.Text = "Ping: -";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.txtOutput.Location = new System.Drawing.Point(12, 142);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(800, 360);
            this.txtOutput.Text = "Witaj w Ping & Net Tester! Kliknij PING lub SPEED TEST, aby rozpocząć.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 512);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 5);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInfo.ForeColor = textSubtle;
            this.lblInfo.Location = new System.Drawing.Point(12, 522);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(256, 13);
            this.lblInfo.Text = "Wyniki są zapisywane do ping_log.txt i ping_results.csv";
        }

        #endregion

        private System.Windows.Forms.ComboBox comboHosts;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkAutoPing;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.Button btnOpenCsv;
        private System.Windows.Forms.Button btnSpeedTest;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblPing;
    }
}