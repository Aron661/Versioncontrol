namespace Olympics
{
    partial class Form1
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
            this.label_year = new System.Windows.Forms.Label();
            this.comboBox_evek = new System.Windows.Forms.ComboBox();
            this.btn_excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(78, 50);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(35, 13);
            this.label_year.TabIndex = 0;
            this.label_year.Text = "Évek:";
            // 
            // comboBox_evek
            // 
            this.comboBox_evek.FormattingEnabled = true;
            this.comboBox_evek.Location = new System.Drawing.Point(119, 50);
            this.comboBox_evek.Name = "comboBox_evek";
            this.comboBox_evek.Size = new System.Drawing.Size(121, 21);
            this.comboBox_evek.TabIndex = 1;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(119, 92);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(121, 23);
            this.btn_excel.TabIndex = 2;
            this.btn_excel.Text = "excelbe mentés";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.comboBox_evek);
            this.Controls.Add(this.label_year);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.ComboBox comboBox_evek;
        private System.Windows.Forms.Button btn_excel;
    }
}

