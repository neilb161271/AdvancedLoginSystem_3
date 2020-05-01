namespace AdvancedLoginSystem
{
    partial class CustomerCarDetails
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBLoginSystemDataSet3 = new AdvancedLoginSystem.DBLoginSystemDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CustRegTxt = new System.Windows.Forms.TextBox();
            this.CustVinNoTxt = new System.Windows.Forms.TextBox();
            this.CustCarMakeTxt = new System.Windows.Forms.TextBox();
            this.CustModelTxt = new System.Windows.Forms.TextBox();
            this.CustYearTxt = new System.Windows.Forms.TextBox();
            this.CustColourTxt = new System.Windows.Forms.TextBox();
            this.CustCarColourCodeTxt = new System.Windows.Forms.TextBox();
            this.CustCarMotTxt = new System.Windows.Forms.TextBox();
            this.CustCarRichTex = new System.Windows.Forms.RichTextBox();
            this.customersTableAdapter = new AdvancedLoginSystem.DBLoginSystemDataSet3TableAdapters.customersTableAdapter();
            this.SaveCuCarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveToFileBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveCusCarFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLoginSystemDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customersBindingSource1, "buiss_name", true));
            this.comboBox1.DataSource = this.dBLoginSystemDataSet3;
            this.comboBox1.DisplayMember = "customers.buiss_name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(646, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(388, 37);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "buiss_name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "customers";
            this.customersBindingSource1.DataSource = this.dBLoginSystemDataSet3;
            // 
            // dBLoginSystemDataSet3
            // 
            this.dBLoginSystemDataSet3.DataSetName = "DBLoginSystemDataSet3";
            this.dBLoginSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Regrestration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Car Vin- No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Car Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year Of Make";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(472, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Colour Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "MOT Due Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(647, 677);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Customer Car Notes";
            // 
            // CustRegTxt
            // 
            this.CustRegTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustRegTxt.Location = new System.Drawing.Point(707, 192);
            this.CustRegTxt.Name = "CustRegTxt";
            this.CustRegTxt.Size = new System.Drawing.Size(327, 35);
            this.CustRegTxt.TabIndex = 11;
            // 
            // CustVinNoTxt
            // 
            this.CustVinNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustVinNoTxt.Location = new System.Drawing.Point(620, 236);
            this.CustVinNoTxt.Name = "CustVinNoTxt";
            this.CustVinNoTxt.Size = new System.Drawing.Size(327, 35);
            this.CustVinNoTxt.TabIndex = 12;
            // 
            // CustCarMakeTxt
            // 
            this.CustCarMakeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCarMakeTxt.Location = new System.Drawing.Point(620, 298);
            this.CustCarMakeTxt.Name = "CustCarMakeTxt";
            this.CustCarMakeTxt.Size = new System.Drawing.Size(327, 35);
            this.CustCarMakeTxt.TabIndex = 13;
            // 
            // CustModelTxt
            // 
            this.CustModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustModelTxt.Location = new System.Drawing.Point(603, 353);
            this.CustModelTxt.Name = "CustModelTxt";
            this.CustModelTxt.Size = new System.Drawing.Size(327, 35);
            this.CustModelTxt.TabIndex = 14;
            // 
            // CustYearTxt
            // 
            this.CustYearTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustYearTxt.Location = new System.Drawing.Point(638, 405);
            this.CustYearTxt.Name = "CustYearTxt";
            this.CustYearTxt.Size = new System.Drawing.Size(327, 35);
            this.CustYearTxt.TabIndex = 15;
            // 
            // CustColourTxt
            // 
            this.CustColourTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustColourTxt.Location = new System.Drawing.Point(563, 465);
            this.CustColourTxt.Name = "CustColourTxt";
            this.CustColourTxt.Size = new System.Drawing.Size(327, 35);
            this.CustColourTxt.TabIndex = 16;
            // 
            // CustCarColourCodeTxt
            // 
            this.CustCarColourCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCarColourCodeTxt.Location = new System.Drawing.Point(628, 516);
            this.CustCarColourCodeTxt.Name = "CustCarColourCodeTxt";
            this.CustCarColourCodeTxt.Size = new System.Drawing.Size(327, 35);
            this.CustCarColourCodeTxt.TabIndex = 17;
            // 
            // CustCarMotTxt
            // 
            this.CustCarMotTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCarMotTxt.Location = new System.Drawing.Point(652, 570);
            this.CustCarMotTxt.Name = "CustCarMotTxt";
            this.CustCarMotTxt.Size = new System.Drawing.Size(327, 35);
            this.CustCarMotTxt.TabIndex = 18;
            // 
            // CustCarRichTex
            // 
            this.CustCarRichTex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCarRichTex.Location = new System.Drawing.Point(477, 725);
            this.CustCarRichTex.Name = "CustCarRichTex";
            this.CustCarRichTex.Size = new System.Drawing.Size(622, 96);
            this.CustCarRichTex.TabIndex = 19;
            this.CustCarRichTex.Text = "";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // SaveCuCarBtn
            // 
            this.SaveCuCarBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveCuCarBtn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.save;
            this.SaveCuCarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveCuCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCuCarBtn.Location = new System.Drawing.Point(20, 32);
            this.SaveCuCarBtn.Name = "SaveCuCarBtn";
            this.SaveCuCarBtn.Size = new System.Drawing.Size(161, 123);
            this.SaveCuCarBtn.TabIndex = 20;
            this.SaveCuCarBtn.UseVisualStyleBackColor = false;
            this.SaveCuCarBtn.Click += new System.EventHandler(this.SaveCuCarBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.SaveToFileBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.SaveCuCarBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 593);
            this.panel1.TabIndex = 21;
            // 
            // SaveToFileBtn
            // 
            this.SaveToFileBtn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.save_filedownload_icon;
            this.SaveToFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveToFileBtn.Location = new System.Drawing.Point(20, 394);
            this.SaveToFileBtn.Name = "SaveToFileBtn";
            this.SaveToFileBtn.Size = new System.Drawing.Size(161, 92);
            this.SaveToFileBtn.TabIndex = 23;
            this.SaveToFileBtn.UseVisualStyleBackColor = true;
            this.SaveToFileBtn.Click += new System.EventHandler(this.SaveToFileBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.close_icon_png;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Location = new System.Drawing.Point(20, 295);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(161, 89);
            this.CloseBtn.TabIndex = 23;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.bin;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.Location = new System.Drawing.Point(20, 161);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(161, 128);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CustomerCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::AdvancedLoginSystem.Properties.Resources.Ford_Focus_RS__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 859);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustCarRichTex);
            this.Controls.Add(this.CustCarMotTxt);
            this.Controls.Add(this.CustCarColourCodeTxt);
            this.Controls.Add(this.CustColourTxt);
            this.Controls.Add(this.CustYearTxt);
            this.Controls.Add(this.CustModelTxt);
            this.Controls.Add(this.CustCarMakeTxt);
            this.Controls.Add(this.CustVinNoTxt);
            this.Controls.Add(this.CustRegTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "CustomerCarDetails";
            this.Text = "Customer Car Details";
            this.Load += new System.EventHandler(this.CustomerCarDetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLoginSystemDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CustRegTxt;
        private System.Windows.Forms.TextBox CustVinNoTxt;
        private System.Windows.Forms.TextBox CustCarMakeTxt;
        private System.Windows.Forms.TextBox CustModelTxt;
        private System.Windows.Forms.TextBox CustYearTxt;
        private System.Windows.Forms.TextBox CustColourTxt;
        private System.Windows.Forms.TextBox CustCarColourCodeTxt;
        private System.Windows.Forms.TextBox CustCarMotTxt;
        private System.Windows.Forms.RichTextBox CustCarRichTex;
        private DBLoginSystemDataSet3 dBLoginSystemDataSet3;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private DBLoginSystemDataSet3TableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button SaveCuCarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.SaveFileDialog SaveCusCarFileDialog;
        private System.Windows.Forms.Button SaveToFileBtn;
    }
}