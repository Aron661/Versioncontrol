namespace Telapo_gyar
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Car = new System.Windows.Forms.Button();
            this.btn_Ball = new System.Windows.Forms.Button();
            this.label_next = new System.Windows.Forms.Label();
            this.btnSzinez = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.btn_dobozszin2 = new System.Windows.Forms.Button();
            this.btn_dobozszin1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 177);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 273);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_Car
            // 
            this.btn_Car.Location = new System.Drawing.Point(67, 13);
            this.btn_Car.Name = "btn_Car";
            this.btn_Car.Size = new System.Drawing.Size(75, 23);
            this.btn_Car.TabIndex = 1;
            this.btn_Car.Text = "CAR";
            this.btn_Car.UseVisualStyleBackColor = true;
            this.btn_Car.Click += new System.EventHandler(this.btn_Car_Click);
            // 
            // btn_Ball
            // 
            this.btn_Ball.Location = new System.Drawing.Point(148, 13);
            this.btn_Ball.Name = "btn_Ball";
            this.btn_Ball.Size = new System.Drawing.Size(75, 23);
            this.btn_Ball.TabIndex = 2;
            this.btn_Ball.Text = "BALL";
            this.btn_Ball.UseVisualStyleBackColor = true;
            this.btn_Ball.Click += new System.EventHandler(this.btn_Ball_Click);
            // 
            // label_next
            // 
            this.label_next.AutoSize = true;
            this.label_next.Location = new System.Drawing.Point(440, 42);
            this.label_next.Name = "label_next";
            this.label_next.Size = new System.Drawing.Size(68, 13);
            this.label_next.TabIndex = 3;
            this.label_next.Text = "Coming next:";
            // 
            // btnSzinez
            // 
            this.btnSzinez.BackColor = System.Drawing.Color.DarkRed;
            this.btnSzinez.Location = new System.Drawing.Point(168, 42);
            this.btnSzinez.Name = "btnSzinez";
            this.btnSzinez.Size = new System.Drawing.Size(33, 28);
            this.btnSzinez.TabIndex = 4;
            this.btnSzinez.UseVisualStyleBackColor = false;
            this.btnSzinez.Click += new System.EventHandler(this.btnSzinez_Click);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(229, 13);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(75, 23);
            this.btnPresent.TabIndex = 5;
            this.btnPresent.Text = "PRESENT";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btn_dobozszin2
            // 
            this.btn_dobozszin2.BackColor = System.Drawing.Color.Coral;
            this.btn_dobozszin2.Location = new System.Drawing.Point(229, 76);
            this.btn_dobozszin2.Name = "btn_dobozszin2";
            this.btn_dobozszin2.Size = new System.Drawing.Size(53, 32);
            this.btn_dobozszin2.TabIndex = 6;
            this.btn_dobozszin2.UseVisualStyleBackColor = false;
            this.btn_dobozszin2.Click += new System.EventHandler(this.btnSzinez_Click);
            // 
            // btn_dobozszin1
            // 
            this.btn_dobozszin1.BackColor = System.Drawing.Color.Silver;
            this.btn_dobozszin1.Location = new System.Drawing.Point(229, 42);
            this.btn_dobozszin1.Name = "btn_dobozszin1";
            this.btn_dobozszin1.Size = new System.Drawing.Size(53, 28);
            this.btn_dobozszin1.TabIndex = 7;
            this.btn_dobozszin1.UseVisualStyleBackColor = false;
            this.btn_dobozszin1.Click += new System.EventHandler(this.btnSzinez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dobozszin1);
            this.Controls.Add(this.btn_dobozszin2);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.btnSzinez);
            this.Controls.Add(this.label_next);
            this.Controls.Add(this.btn_Ball);
            this.Controls.Add(this.btn_Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btn_Car;
        private System.Windows.Forms.Button btn_Ball;
        private System.Windows.Forms.Label label_next;
        private System.Windows.Forms.Button btnSzinez;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btn_dobozszin2;
        private System.Windows.Forms.Button btn_dobozszin1;
    }
}

