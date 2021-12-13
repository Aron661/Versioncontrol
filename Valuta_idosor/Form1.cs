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
            LoadXml(GetExchangeRates());        //3.GetExchangeRates() ami string átad Loadxmlbe
            dataGridView_Rates.DataSource = Rates;
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
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";

            var response = mnbService.GetExchangeRates(request); //Hívd meg az mnbService GetExchangeRates nevű függvényét a request bemeneti paraméterrel, és a függvény visszatérési értékét tárold egy response nevű változóba
            return response.GetExchangeRatesResult;  //2. var result helyett - return kimenet
            //File.WriteAllText("teszt.xml", result);  - kiiratás result xml - debug

        }
    }
}
