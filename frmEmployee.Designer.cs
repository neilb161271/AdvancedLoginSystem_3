namespace AdvancedLoginSystem
{
    partial class FrmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.empJobsBtn = new System.Windows.Forms.Button();
            this.ShowCreatPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome employee";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 105);
            this.button1.TabIndex = 1;
            this.button1.Text = "book\r\nholiday";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            //this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button2.Location = new System.Drawing.Point(240, 333);
            //this.button2.Name = "button2";
            //this.button2.Size = new System.Drawing.Size(130, 105);
            //this.button2.TabIndex = 2;
            //this.button2.Text = "clock\r\nIn";
            //this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            //// 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(416, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 105);
            this.button3.TabIndex = 3;
            this.button3.Text = "clock\r\nout";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // empJobsBtn
            // 
            this.empJobsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empJobsBtn.Location = new System.Drawing.Point(593, 339);
            this.empJobsBtn.Name = "empJobsBtn";
            this.empJobsBtn.Size = new System.Drawing.Size(130, 101);
            this.empJobsBtn.TabIndex = 4;
            this.empJobsBtn.Text = "jobs";
            this.empJobsBtn.UseVisualStyleBackColor = true;
            this.empJobsBtn.Click += new System.EventHandler(this.EmpJobsBtn_Click);
            // 
            // ShowCreatPin
            // 
           
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.black_white_glow_gradient_hexagon_green_1920x1080_c4_000000_ffffff_556b2f_000000_l2_2_35_a_30_f_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 778);
            this.Controls.Add(this.ShowCreatPin);
            this.Controls.Add(this.empJobsBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Page";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button empJobsBtn;
        private System.Windows.Forms.Button ShowCreatPin;
    }
}