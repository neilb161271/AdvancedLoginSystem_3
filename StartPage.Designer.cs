namespace AdvancedLoginSystem
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartBtn = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.Main_Timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_date = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminHelpBtn = new System.Windows.Forms.Button();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.loginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ShutdownToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.AutoSize = true;
            this.StartBtn.BackColor = System.Drawing.Color.Black;
            this.StartBtn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.loginbutton__1_;
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(22, 29);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(196, 78);
            this.StartBtn.TabIndex = 1;
            this.loginToolTip.SetToolTip(this.StartBtn, "Login button For\r\nAdmin and Employees.\r\nStart Here!");
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Green;
            this.lbl_time.Location = new System.Drawing.Point(3, 57);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(184, 69);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "00:00";
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sec.ForeColor = System.Drawing.Color.Green;
            this.lbl_sec.Location = new System.Drawing.Point(197, 84);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(51, 36);
            this.lbl_sec.TabIndex = 1;
            this.lbl_sec.Text = "00";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.BackColor = System.Drawing.Color.Transparent;
            this.lbl_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day.ForeColor = System.Drawing.Color.Green;
            this.lbl_day.Location = new System.Drawing.Point(466, 84);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(70, 36);
            this.lbl_day.TabIndex = 2;
            this.lbl_day.Text = "Day";
            // 
            // Main_Timer
            // 
            this.Main_Timer.Enabled = true;
            this.Main_Timer.Tick += new System.EventHandler(this.Main_Timer_Tick);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Green;
            this.lbl_date.Location = new System.Drawing.Point(273, 84);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(175, 36);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "MM-DD-YY";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.backgroundGrad2;
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_day);
            this.panel1.Controls.Add(this.lbl_sec);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(628, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 131);
            this.panel1.TabIndex = 4;
            // 
            // AdminHelpBtn
            // 
            this.AdminHelpBtn.BackColor = System.Drawing.Color.Black;
            this.AdminHelpBtn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.Helpbutton;
            this.AdminHelpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminHelpBtn.Location = new System.Drawing.Point(22, 136);
            this.AdminHelpBtn.Name = "AdminHelpBtn";
            this.AdminHelpBtn.Size = new System.Drawing.Size(196, 78);
            this.AdminHelpBtn.TabIndex = 5;
            this.HelpToolTip.SetToolTip(this.AdminHelpBtn, "To set up this software\r\n please read this...");
            this.AdminHelpBtn.UseVisualStyleBackColor = false;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.BackColor = System.Drawing.Color.Black;
            this.ShutdownButton.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.shutdownbutton;
            this.ShutdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutdownButton.Location = new System.Drawing.Point(22, 239);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(196, 78);
            this.ShutdownButton.TabIndex = 6;
            this.ShutdownToolTip.SetToolTip(this.ShutdownButton, "Before you shutdown,\r\nplease make sure all your \r\nwork has been saved \r\nto the da" +
        "tabase...\r\n");
            this.ShutdownButton.UseVisualStyleBackColor = false;
            // 
            // loginToolTip
            // 
            this.loginToolTip.AutoPopDelay = 5000;
            this.loginToolTip.InitialDelay = 500;
            this.loginToolTip.IsBalloon = true;
            this.loginToolTip.ReshowDelay = 300;
            this.loginToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // HelpToolTip
            // 
            this.HelpToolTip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HelpToolTip.IsBalloon = true;
            // 
            // ShutdownToolTip
            // 
            this.ShutdownToolTip.IsBalloon = true;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.black_white_glow_gradient_hexagon_green_1920x1080_c4_000000_ffffff_556b2f_000000_l2_2_35_a_30_f_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 646);
            this.Controls.Add(this.AdminHelpBtn);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartBtn);
            this.DoubleBuffered = true;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Page @Neil Bennett 2020";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Timer Main_Timer;
        private System.Windows.Forms.Label lbl_date;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AdminHelpBtn;
        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.ToolTip loginToolTip;
        private System.Windows.Forms.ToolTip HelpToolTip;
        private System.Windows.Forms.ToolTip ShutdownToolTip;
        //added clock

    }
}