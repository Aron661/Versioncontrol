using Olympics.Entities;
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

namespace Olympics
{
    public partial class Form1 : Form
    {
        List<OlympicResult> results = new List<OlympicResult>();  //Hozz létre egy OlympicResult-okból álló listát a Form1 osztály szintjén results néven.

        public Form1()
        {
            InitializeComponent();
            betoltes("Summer_olympic_Medals.csv");

        }

        private void betoltes(string fajlnev)
        {
            using (StreamReader sr= new StreamReader(fajlnev)) 
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

                    results.Add(peldany);

                }
            } 
        }
    }
}
