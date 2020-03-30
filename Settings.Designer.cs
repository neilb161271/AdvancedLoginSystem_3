namespace AdvancedLoginSystem
{
    partial class Settings
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
            this.ShowCreatPin = new System.Windows.Forms.Button();
            this.CloseBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowCreatPin
            // 
            this.ShowCreatPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCreatPin.Location = new System.Drawing.Point(23, 27);
            this.ShowCreatPin.Name = "ShowCreatPin";
            this.ShowCreatPin.Size = new System.Drawing.Size(137, 72);
            this.ShowCreatPin.TabIndex = 6;
            this.ShowCreatPin.Text = "Create Pin-Number";
            this.ShowCreatPin.UseVisualStyleBackColor = true;
            // 
            // CloseBttn
            // 
            this.CloseBttn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.backgroundGrad2;
            this.CloseBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBttn.Location = new System.Drawing.Point(611, 386);
            this.CloseBttn.Name = "CloseBttn";
            this.CloseBttn.Size = new System.Drawing.Size(177, 52);
            this.CloseBttn.TabIndex = 7;
            this.CloseBttn.Text = "Close..";
            this.CloseBttn.UseVisualStyleBackColor = true;
            this.CloseBttn.Click += new System.EventHandler(this.CloseBttn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBttn);
            this.Controls.Add(this.ShowCreatPin);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowCreatPin;
        private System.Windows.Forms.Button CloseBttn;
    }
}