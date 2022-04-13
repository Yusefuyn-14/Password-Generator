namespace YK_47_Password_Generator
{
    partial class passwordGeneratorForm
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.checkBoxUpChar = new System.Windows.Forms.CheckBox();
            this.checkBoxLowChar = new System.Windows.Forms.CheckBox();
            this.checkBoxNumeric = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbol = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(74, 156);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(202, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.checkBoxSpecial);
            this.panel1.Controls.Add(this.checkBoxSymbol);
            this.panel1.Controls.Add(this.checkBoxNumeric);
            this.panel1.Controls.Add(this.checkBoxLowChar);
            this.panel1.Controls.Add(this.checkBoxUpChar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 130);
            this.panel1.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.Location = new System.Drawing.Point(0, 130);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(284, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(74, 182);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(202, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Kopyala";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // checkBoxUpChar
            // 
            this.checkBoxUpChar.AutoSize = true;
            this.checkBoxUpChar.Location = new System.Drawing.Point(12, 12);
            this.checkBoxUpChar.Name = "checkBoxUpChar";
            this.checkBoxUpChar.Size = new System.Drawing.Size(43, 17);
            this.checkBoxUpChar.TabIndex = 0;
            this.checkBoxUpChar.Text = "A-Z";
            this.checkBoxUpChar.UseVisualStyleBackColor = true;
            this.checkBoxUpChar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxLowChar
            // 
            this.checkBoxLowChar.AutoSize = true;
            this.checkBoxLowChar.Location = new System.Drawing.Point(12, 35);
            this.checkBoxLowChar.Name = "checkBoxLowChar";
            this.checkBoxLowChar.Size = new System.Drawing.Size(40, 17);
            this.checkBoxLowChar.TabIndex = 1;
            this.checkBoxLowChar.Text = "a-z";
            this.checkBoxLowChar.UseVisualStyleBackColor = true;
            this.checkBoxLowChar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxNumeric
            // 
            this.checkBoxNumeric.AutoSize = true;
            this.checkBoxNumeric.Location = new System.Drawing.Point(12, 58);
            this.checkBoxNumeric.Name = "checkBoxNumeric";
            this.checkBoxNumeric.Size = new System.Drawing.Size(41, 17);
            this.checkBoxNumeric.TabIndex = 2;
            this.checkBoxNumeric.Text = "0-9";
            this.checkBoxNumeric.UseVisualStyleBackColor = true;
            this.checkBoxNumeric.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxSymbol
            // 
            this.checkBoxSymbol.AutoSize = true;
            this.checkBoxSymbol.Location = new System.Drawing.Point(12, 81);
            this.checkBoxSymbol.Name = "checkBoxSymbol";
            this.checkBoxSymbol.Size = new System.Drawing.Size(49, 17);
            this.checkBoxSymbol.TabIndex = 3;
            this.checkBoxSymbol.Text = "@_?";
            this.checkBoxSymbol.UseVisualStyleBackColor = true;
            this.checkBoxSymbol.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Location = new System.Drawing.Point(12, 104);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSpecial.TabIndex = 4;
            this.checkBoxSpecial.Text = "İmza Partikülleri";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            this.checkBoxSpecial.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(64, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uzunluk :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(64, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yöntem :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YK-47 Password Generator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.CheckBox checkBoxSymbol;
        private System.Windows.Forms.CheckBox checkBoxNumeric;
        private System.Windows.Forms.CheckBox checkBoxLowChar;
        private System.Windows.Forms.CheckBox checkBoxUpChar;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
    }
}

