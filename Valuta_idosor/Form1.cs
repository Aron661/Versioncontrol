using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using Valuta_idosor.Entities;
using Valuta_idosor.MNBServiceReference;

namespace Valuta_idosor
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();

        public Form1()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData() //konst-ból kiszervezve -dinamikus
        {
            if (comboBox_CURR.SelectedItem == null) return; //dinamikus után üres combobox miatt

            Rates.Clear();
            LoadXml(GetExchangeRates());        //3.GetExchangeRates() ami string átad Loadxmlbe
            dataGridView_Rates.DataSource = Rates;
            makeChart();
        }

        private void makeChart()
        {
            chartRateData.DataSource = Rates;
            Series sorozatok = chartRateData.Series[0];

            sorozatok.ChartType = SeriesChartType.Line; //bekell hívatkozni
            sorozatok.XValueMember = "Date";
            sorozatok.YValueMembers = "Value";

            sorozatok.BorderWidth = 2; //Az adatsor vastagsága legyen kétszeres

            var jelmagyarazat = chartRateData.Legends[0];
            jelmagyarazat.Enabled = false; //kikapcs chart-ban jelmagyarázat - legends

            var diagrammterulet = chartRateData.ChartAreas[0];
            diagrammterulet.AxisY.IsStartedFromZero = false; //ne 0-tól y tengely chartban

            diagrammterulet.AxisX.MajorGrid.Enabled = false;
            diagrammterulet.AxisY.MajorGrid.Enabled = false; //rács- grid kikapcs


        }

        private void LoadXml(string result) //4. (string ..)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result); //5. = át kell adnod a korábbi result-ot ennek a függvénynek

            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData r = new RateData();
                r.Date = DateTime.Parse(item.GetAttribute("date")); //item.GetAttribute("date");

                var childElement = (XmlElement)item.ChildNodes[0];
                r.Currency = childElement.GetAttribute("curr");

                decimal unit = decimal.Parse(childElement.GetAttribute("unit")); //egész szám (1 és felkészülni hogy nem 0- osztás m)
                r.Value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    r.Value = r.Value / unit;

                Rates.Add(r);/////
            }
        }

        private string GetExchangeRates() //1.string bemeneti értékre vált
        {
           
            var mnbService = new MNBArfolyamServiceSoapClient(); //MNBServiceReference.MNBArfolyamServiceSoapClient() a rövidítés miatt - MNBServiceReference usinggal (quick..)
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames =comboBox_CURR.SelectedItem.ToString() ;  //"EUR"
            request.startDate = dateTimePicker_Kezd.Value.ToString("yyyy-MM-dd");  //"2020-01-01" - dinamikus lett
            request.endDate = dateTimePicker_Veg.Value.ToString();     //"2020-06-30" 

            var response = mnbService.GetExchangeRates(request); //Hívd meg az mnbService GetExchangeRates nevű függvényét a request bemeneti paraméterrel, és a függvény visszatérési értékét tárold egy response nevű változóba
            return response.GetExchangeRatesResult;  //2. var result helyett - return kimenet
            //File.WriteAllText("teszt.xml", result);  - kiiratás result xml - debug

        }

        private void dateTimePicker_Kezd_ValueChanged(object sender, EventArgs e) //lehetne szebben is egy metódusba és elemenként behiv
        {
            RefreshData();
        }

        private void dateTimePicker_Veg_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox_CURR_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
