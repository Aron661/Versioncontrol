namespace Mikroszimulacio10
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_zarev = new System.Windows.Forms.Label();
            this.label_nepes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 17);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label_zarev
            // 
            this.label_zarev.AutoSize = true;
            this.label_zarev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zarev.Location = new System.Drawing.Point(12, 20);
            this.label_zarev.Name = "label_zarev";
            this.label_zarev.Size = new System.Drawing.Size(47, 13);
            this.label_zarev.TabIndex = 1;
            this.label_zarev.Text = "Záróév";
            // 
            // label_nepes
            // 
            this.label_nepes.AutoSize = true;
            this.label_nepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nepes.Location = new System.Drawing.Point(197, 20);
            this.label_nepes.Name = "label_nepes";
            this.label_nepes.Size = new System.Drawing.Size(84, 13);
            this.label_nepes.TabIndex = 2;
            this.label_nepes.Text = "Népesség fájl";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(591, 17);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 4;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(690, 16);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(753, 424);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 467);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_nepes);
            this.Controls.Add(this.label_zarev);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_zarev;
        private System.Windows.Forms.Label label_nepes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

