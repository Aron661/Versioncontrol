using Olympics.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Olympics
{
    public partial class Form1 : Form
    {
        List<OlympicResult> results = new List<OlympicResult>();  //Hozz létre egy OlympicResult-okból álló listát a Form1 osztály szintjén results néven.
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;

        public Form1()
        {
            InitializeComponent();
            betoltes("Summer_olympic_Medals.csv");
            evvalasztas();
            osztalyozas();

        }

        private void osztalyozas()
        {
            foreach (OlympicResult item in results)
            {
                item.Position = helyezes(item);
            }
        }

        int helyezes(OlympicResult re)
        {
            int szamlalo = 0;
            var szurtlista = from x in results where x.Year == re.Year && x.Country != re.Country select x;
            foreach (OlympicResult item in szurtlista)
            {
                if (item.Medals[0] > re.Medals[0]) szamlalo++;
                else if ((item.Medals[0] == re.Medals[0]) && (item.Medals[1] > re.Medals[1])) szamlalo++;
                else if ((item.Medals[0] == re.Medals[0]) && (item.Medals[1] == re.Medals[1]) && (item.Medals[2] > re.Medals[2])) szamlalo++;
                //Egy ciklussal menj végig a szűrt listán. Növeld a számlálót, ha az alábbiak valamelyike teljesül
            }
            return szamlalo + 1; //Ezt követően a függvény térjen vissza a számlálónál eggyel nagyobb számmal (azaz a helyezéssel).
        }

        private void evvalasztas() //combobox feltölt
        {
            var years = (from x in results orderby x.Year select x.Year).Distinct();
            //A függvényben írj LINQ lekérdezést, ami a results tartalmából lekérdezi az éveket, sorba rendezi azokat, és kiszűri a duplikátumokat
            comboBox_evek.DataSource = years.ToList();  //combobox kell a .Tolist() 
        }


        private void betoltes(string fajlnev)
        {
            using (StreamReader sr = new StreamReader(fajlnev))
            {
                sr.ReadLine(); //első sor beolvasása csv.ből fejléc - amivel nem csinálunk "semmit"
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine(); //csv sora
                    string[] mezok = sor.Split(',');

                    OlympicResult peldany = new OlympicResult();
                    peldany.Year = int.Parse(mezok[0]);
                    peldany.Country = mezok[3];
                    //5. 6. 7. oszlop arany , ezüst , bronz
                    int[] mtomb = new int[3]; //3 elemű tömb felvétele
                    mtomb[0] = int.Parse(mezok[5]); //arany
                    mtomb[1] = int.Parse(mezok[6]); //ezüst
                    mtomb[2] = int.Parse(mezok[7]); //bronz

                    peldany.Medals = mtomb;
                    results.Add(peldany);

                }
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                // Excel feltöltése
                Excelfeltolt();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void Excelfeltolt()
        {
            var headers = new string[]
            {
               "Helyezés","Ország", "Arany", "Ezüst", "Bronz"
            };
            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells [1,i+1]= headers[i];
            }

            var filteredresult = from x in results where x.Year == (int)comboBox_evek.SelectedItem orderby x.Position select x;
            //LINQ segítségével szűrd le a results tartalmát úgy, hogy csak a legördülő lista szerint kiválasztott éve értékei szerepeljenek benne, és az értékek a helyezés szerint legyenek sorba rendezve

            int aktsor = 2; //2.sortól

            foreach (var item in filteredresult)
            {
                xlSheet.Cells[aktsor, 1] = item.Position;
                xlSheet.Cells[aktsor, 2] = item.Country;
                for (int i = 0; i < 3; i++)
                {
                    xlSheet.Cells[aktsor, 3+i] = item.Medals[i];
                }
                aktsor++;

            }
        }

    }
}
