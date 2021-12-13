namespace Valuta_idosor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView_Rates = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_Kezd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Veg = new System.Windows.Forms.DateTimePicker();
            this.comboBox_CURR = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Rates
            // 
            this.dataGridView_Rates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rates.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_Rates.Name = "dataGridView_Rates";
            this.dataGridView_Rates.Size = new System.Drawing.Size(358, 318);
            this.dataGridView_Rates.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRateData.Legends.Add(legend5);
            this.chartRateData.Location = new System.Drawing.Point(376, 41);
            this.chartRateData.Name = "chartRateData";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartRateData.Series.Add(series5);
            this.chartRateData.Size = new System.Drawing.Size(507, 391);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // dateTimePicker_Kezd
            // 
            this.dateTimePicker_Kezd.Location = new System.Drawing.Point(28, 13);
            this.dateTimePicker_Kezd.Name = "dateTimePicker_Kezd";
            this.dateTimePicker_Kezd.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker_Kezd.TabIndex = 2;
            this.dateTimePicker_Kezd.ValueChanged += new System.EventHandler(this.dateTimePicker_Kezd_ValueChanged);
            // 
            // dateTimePicker_Veg
            // 
            this.dateTimePicker_Veg.Location = new System.Drawing.Point(225, 13);
            this.dateTimePicker_Veg.Name = "dateTimePicker_Veg";
            this.dateTimePicker_Veg.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker_Veg.TabIndex = 3;
            this.dateTimePicker_Veg.ValueChanged += new System.EventHandler(this.dateTimePicker_Veg_ValueChanged);
            // 
            // comboBox_CURR
            // 
            this.comboBox_CURR.FormattingEnabled = true;
            this.comboBox_CURR.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.comboBox_CURR.Location = new System.Drawing.Point(423, 11);
            this.comboBox_CURR.Name = "comboBox_CURR";
            this.comboBox_CURR.Size = new System.Drawing.Size(121, 21);
            this.comboBox_CURR.TabIndex = 4;
            this.comboBox_CURR.SelectedIndexChanged += new System.EventHandler(this.comboBox_CURR_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.comboBox_CURR);
            this.Controls.Add(this.dateTimePicker_Veg);
            this.Controls.Add(this.dateTimePicker_Kezd);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGridView_Rates);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Rates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Kezd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Veg;
        private System.Windows.Forms.ComboBox comboBox_CURR;
    }
}

