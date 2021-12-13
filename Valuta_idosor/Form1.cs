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
            GetExchangeRates();
            dataGridView_Rates.DataSource = Rates;
        }

        private void GetExchangeRates()
        {
            var mnbService = new MNBArfolyamServiceSoapClient(); //MNBServiceReference.MNBArfolyamServiceSoapClient() a rövidítés miatt - MNBServiceReference usinggal (quick..)
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";

            var response = mnbService.GetExchangeRates(request); //Hívd meg az mnbService GetExchangeRates nevű függvényét a request bemeneti paraméterrel, és a függvény visszatérési értékét tárold egy response nevű változóba
            var result = response.GetExchangeRatesResult;
            //File.WriteAllText("teszt.xml", result);  - kiiratás result xml - debug

        }
    }
}
