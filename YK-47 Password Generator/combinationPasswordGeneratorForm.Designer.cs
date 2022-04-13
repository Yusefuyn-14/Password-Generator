namespace YK_47_Password_Generator
{
    partial class combinationPasswordGeneratorForm
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
            this.listPassword = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPasswordAdd = new System.Windows.Forms.Button();
            this.btnSelectedPasswordRemove = new System.Windows.Forms.Button();
            this.btnPasswordInport = new System.Windows.Forms.Button();
            this.btnPasswordExport = new System.Windows.Forms.Button();
            this.Crate = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btnResultExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPassword
            // 
            this.listPassword.FormattingEnabled = true;
            this.listPassword.Location = new System.Drawing.Point(12, 12);
            this.listPassword.Name = "listPassword";
            this.listPassword.Size = new System.Drawing.Size(182, 160);
            this.listPassword.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnPasswordAdd
            // 
            this.btnPasswordAdd.Location = new System.Drawing.Point(200, 33);
            this.btnPasswordAdd.Name = "btnPasswordAdd";
            this.btnPasswordAdd.Size = new System.Drawing.Size(151, 23);
            this.btnPasswordAdd.TabIndex = 2;
            this.btnPasswordAdd.Text = "Ekle";
            this.btnPasswordAdd.UseVisualStyleBackColor = true;
            this.btnPasswordAdd.Click += new System.EventHandler(this.btnPasswordAdd_Click);
            // 
            // btnSelectedPasswordRemove
            // 
            this.btnSelectedPasswordRemove.Location = new System.Drawing.Point(200, 57);
            this.btnSelectedPasswordRemove.Name = "btnSelectedPasswordRemove";
            this.btnSelectedPasswordRemove.Size = new System.Drawing.Size(151, 23);
            this.btnSelectedPasswordRemove.TabIndex = 3;
            this.btnSelectedPasswordRemove.Text = "Seçileni Kaldır";
            this.btnSelectedPasswordRemove.UseVisualStyleBackColor = true;
            this.btnSelectedPasswordRemove.Click += new System.EventHandler(this.btnSelectedPasswordRemove_Click);
            // 
            // btnPasswordInport
            // 
            this.btnPasswordInport.Location = new System.Drawing.Point(200, 149);
            this.btnPasswordInport.Name = "btnPasswordInport";
            this.btnPasswordInport.Size = new System.Drawing.Size(151, 23);
            this.btnPasswordInport.TabIndex = 4;
            this.btnPasswordInport.Text = "İçe Aktar";
            this.btnPasswordInport.UseVisualStyleBackColor = true;
            this.btnPasswordInport.Click += new System.EventHandler(this.btnPasswordInport_Click);
            // 
            // btnPasswordExport
            // 
            this.btnPasswordExport.Location = new System.Drawing.Point(200, 124);
            this.btnPasswordExport.Name = "btnPasswordExport";
            this.btnPasswordExport.Size = new System.Drawing.Size(151, 23);
            this.btnPasswordExport.TabIndex = 5;
            this.btnPasswordExport.Text = "Dışa Aktar";
            this.btnPasswordExport.UseVisualStyleBackColor = true;
            this.btnPasswordExport.Click += new System.EventHandler(this.btnPasswordExport_Click);
            // 
            // Crate
            // 
            this.Crate.Location = new System.Drawing.Point(12, 178);
            this.Crate.Name = "Crate";
            this.Crate.Size = new System.Drawing.Size(339, 23);
            this.Crate.TabIndex = 6;
            this.Crate.Text = "Asenkron Oluştur";
            this.Crate.UseVisualStyleBackColor = true;
            this.Crate.Click += new System.EventHandler(this.Crate_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(12, 207);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(339, 160);
            this.listResult.TabIndex = 7;
            // 
            // btnResultExport
            // 
            this.btnResultExport.Location = new System.Drawing.Point(12, 373);
            this.btnResultExport.Name = "btnResultExport";
            this.btnResultExport.Size = new System.Drawing.Size(339, 23);
            this.btnResultExport.TabIndex = 8;
            this.btnResultExport.Text = "Sonuçu Dışa Aktar";
            this.btnResultExport.UseVisualStyleBackColor = true;
            this.btnResultExport.Click += new System.EventHandler(this.btnResultExport_Click);
            // 
            // combinationPasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 403);
            this.Controls.Add(this.btnResultExport);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.Crate);
            this.Controls.Add(this.btnPasswordExport);
            this.Controls.Add(this.btnPasswordInport);
            this.Controls.Add(this.btnSelectedPasswordRemove);
            this.Controls.Add(this.btnPasswordAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listPassword);
            this.Name = "combinationPasswordGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "combinationPasswordGeneratorForm";
            this.Load += new System.EventHandler(this.combinationPasswordGeneratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPasswordAdd;
        private System.Windows.Forms.Button btnSelectedPasswordRemove;
        private System.Windows.Forms.Button btnPasswordInport;
        private System.Windows.Forms.Button btnPasswordExport;
        private System.Windows.Forms.Button Crate;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button btnResultExport;
    }
}