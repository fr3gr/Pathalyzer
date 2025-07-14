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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboHosts = new ComboBox();
            txtOutput = new RichTextBox();
            btnPing = new Button();
            numCount = new NumericUpDown();
            txtCustom = new TextBox();
            lblInfo = new Label();
            btnCancel = new Button();
            progressBar = new ProgressBar();
            chkAutoPing = new CheckBox();
            btnClear = new Button();
            btnOpenLog = new Button();
            btnOpenCsv = new Button();
            btnSpeedTest = new Button();
            lblDownload = new Label();
            lblUpload = new Label();
            lblPing = new Label();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            SuspendLayout();
            // 
            // comboHosts
            // 
            comboHosts.BackColor = Color.FromArgb(63, 63, 70);
            comboHosts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHosts.FlatStyle = FlatStyle.Flat;
            comboHosts.Font = new Font("Segoe UI", 10F);
            comboHosts.ForeColor = Color.FromArgb(241, 241, 241);
            comboHosts.FormattingEnabled = true;
            comboHosts.Items.AddRange(new object[] { "Domyślne DNS", "8.8.8.8", "1.1.1.1", "9.9.9.9", "208.67.222.222", "8.8.4.4" });
            comboHosts.Location = new Point(22, 23);
            comboHosts.Name = "comboHosts";
            comboHosts.Size = new Size(150, 25);
            comboHosts.TabIndex = 14;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.FromArgb(20, 20, 20);
            txtOutput.BorderStyle = BorderStyle.None;
            txtOutput.Font = new Font("Consolas", 10F);
            txtOutput.ForeColor = Color.FromArgb(220, 220, 220);
            txtOutput.Location = new Point(12, 142);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(800, 360);
            txtOutput.TabIndex = 15;
            txtOutput.Text = "Witaj w Ping & Net Tester! Kliknij PING lub SPEED TEST, aby rozpocząć.";
            // 
            // btnPing
            // 
            btnPing.BackColor = Color.FromArgb(0, 122, 204);
            btnPing.FlatAppearance.BorderSize = 0;
            btnPing.FlatStyle = FlatStyle.Flat;
            btnPing.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnPing.Location = new Point(452, 21);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(110, 30);
            btnPing.TabIndex = 11;
            btnPing.Text = "PING 🌐";
            btnPing.UseVisualStyleBackColor = false;
            btnPing.Click += btnPing_Click;
            // 
            // numCount
            // 
            numCount.BackColor = Color.FromArgb(63, 63, 70);
            numCount.Font = new Font("Segoe UI", 10F);
            numCount.ForeColor = Color.FromArgb(241, 241, 241);
            numCount.Location = new Point(392, 23);
            numCount.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCount.Name = "numCount";
            numCount.Size = new Size(50, 25);
            numCount.TabIndex = 12;
            numCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // txtCustom
            // 
            txtCustom.BackColor = Color.FromArgb(63, 63, 70);
            txtCustom.BorderStyle = BorderStyle.FixedSingle;
            txtCustom.Font = new Font("Segoe UI", 10F);
            txtCustom.ForeColor = Color.FromArgb(241, 241, 241);
            txtCustom.Location = new Point(182, 23);
            txtCustom.Name = "txtCustom";
            txtCustom.PlaceholderText = "lub wpisz własny host...";
            txtCustom.Size = new Size(200, 25);
            txtCustom.TabIndex = 13;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 8F);
            lblInfo.ForeColor = Color.FromArgb(150, 150, 150);
            lblInfo.Location = new Point(12, 522);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(290, 13);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Wyniki są zapisywane do ping_log.txt i ping_results.csv";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 57, 43);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(164, 68);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 28);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Anuluj \U0001f6d1";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 512);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(800, 5);
            progressBar.TabIndex = 1;
            // 
            // chkAutoPing
            // 
            chkAutoPing.AutoSize = true;
            chkAutoPing.Font = new Font("Segoe UI", 9F);
            chkAutoPing.Location = new Point(24, 73);
            chkAutoPing.Name = "chkAutoPing";
            chkAutoPing.Size = new Size(129, 19);
            chkAutoPing.TabIndex = 9;
            chkAutoPing.Text = "Pinguj cyklicznie 🔄";
            chkAutoPing.UseVisualStyleBackColor = true;
            chkAutoPing.CheckedChanged += chkAutoPing_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(63, 63, 70);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F);
            btnClear.Location = new Point(260, 68);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 28);
            btnClear.TabIndex = 8;
            btnClear.Text = "Wyczyść 🗑️";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnOpenLog
            // 
            btnOpenLog.BackColor = Color.FromArgb(63, 63, 70);
            btnOpenLog.FlatAppearance.BorderSize = 0;
            btnOpenLog.FlatStyle = FlatStyle.Flat;
            btnOpenLog.Font = new Font("Segoe UI Semibold", 9F);
            btnOpenLog.Location = new Point(355, 68);
            btnOpenLog.Name = "btnOpenLog";
            btnOpenLog.Size = new Size(100, 28);
            btnOpenLog.TabIndex = 7;
            btnOpenLog.Text = "Otwórz Log 📝";
            btnOpenLog.UseVisualStyleBackColor = false;
            btnOpenLog.Click += btnOpenLog_Click;
            // 
            // btnOpenCsv
            // 
            btnOpenCsv.BackColor = Color.FromArgb(63, 63, 70);
            btnOpenCsv.FlatAppearance.BorderSize = 0;
            btnOpenCsv.FlatStyle = FlatStyle.Flat;
            btnOpenCsv.Font = new Font("Segoe UI Semibold", 9F);
            btnOpenCsv.Location = new Point(465, 68);
            btnOpenCsv.Name = "btnOpenCsv";
            btnOpenCsv.Size = new Size(100, 28);
            btnOpenCsv.TabIndex = 6;
            btnOpenCsv.Text = "Otwórz CSV 📊";
            btnOpenCsv.UseVisualStyleBackColor = false;
            btnOpenCsv.Click += btnOpenCsv_Click;
            // 
            // btnSpeedTest
            // 
            btnSpeedTest.BackColor = Color.FromArgb(0, 122, 204);
            btnSpeedTest.FlatAppearance.BorderSize = 0;
            btnSpeedTest.FlatStyle = FlatStyle.Flat;
            btnSpeedTest.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSpeedTest.Location = new Point(588, 21);
            btnSpeedTest.Name = "btnSpeedTest";
            btnSpeedTest.Size = new Size(212, 30);
            btnSpeedTest.TabIndex = 5;
            btnSpeedTest.Text = "SPEED TEST ⚡";
            btnSpeedTest.UseVisualStyleBackColor = false;
            btnSpeedTest.Click += btnSpeedTest_Click;
            // 
            // lblDownload
            // 
            lblDownload.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDownload.ForeColor = Color.Gold;
            lblDownload.Location = new Point(588, 62);
            lblDownload.Name = "lblDownload";
            lblDownload.Size = new Size(212, 20);
            lblDownload.TabIndex = 3;
            lblDownload.Text = "Download: -";
            // 
            // lblUpload
            // 
            lblUpload.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUpload.ForeColor = Color.DeepSkyBlue;
            lblUpload.Location = new Point(588, 87);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(212, 20);
            lblUpload.TabIndex = 2;
            lblUpload.Text = "Upload: -";
            // 
            // lblPing
            // 
            lblPing.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPing.ForeColor = Color.LawnGreen;
            lblPing.Location = new Point(588, 112);
            lblPing.Name = "lblPing";
            lblPing.Size = new Size(212, 20);
            lblPing.TabIndex = 4;
            lblPing.Text = "Ping: -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(824, 541);
            Controls.Add(lblInfo);
            Controls.Add(progressBar);
            Controls.Add(lblUpload);
            Controls.Add(lblDownload);
            Controls.Add(lblPing);
            Controls.Add(btnSpeedTest);
            Controls.Add(btnOpenCsv);
            Controls.Add(btnOpenLog);
            Controls.Add(btnClear);
            Controls.Add(chkAutoPing);
            Controls.Add(btnCancel);
            Controls.Add(btnPing);
            Controls.Add(numCount);
            Controls.Add(txtCustom);
            Controls.Add(comboHosts);
            Controls.Add(txtOutput);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ping & Net Tester";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
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