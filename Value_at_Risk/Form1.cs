﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Value_at_Risk.Entities;

namespace Value_at_Risk
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();
        List<decimal> Nyereségek; //osztály szintjére fájlba mentésnél ff

        public Form1()
        {
            InitializeComponent();
            ticks = context.Ticks.ToList();
            dataGridView1.DataSource = ticks;
            CreatePortfolio();

            /* vizsgálat 6. a. Portfóliónk elemszáma:
            int elemszám = Portfolio.Count(); //A Count() bálrmilyen megszámlálható listára alkalmazható. */

            /*b. A portfólióban szereplő részvények darabszáma:
            decimal részvényekSzáma = (from x in Portfolio select x.Volume).Sum();
            MessageBox.Show(string.Format("Részvények száma: {0}", részvényekSzáma));
            */
            //Először egy listába kigyűjtjük csak a darabszámokat, majd az egész bezárójlezett listát summázzuk. 
            //(A zárójelben lévő LINQ egy int-ekből álló listát ad, mert a Count tulajdonság int típusú.)
            //Működik a Min(), Max(), Average(), stb. is.

            /*c. A legrégebbi kereskedési nap:
            DateTime minDátum = (from x in ticks select x.TradingDay).Min(); */

            /*d. A legutolsó kereskedési nap:
            DateTime maxDátum = (from x in ticks select x.TradingDay).Max(); */

            /*e. A két dátum közt eltelt idő napokban -- két DateTime típusú objektum különbsége TimeSpan típusú eredményt ad.
            //A TimeSpan Day tulajdonsága megadja az időtartam napjainak számát. (Nem kell vacakolni a szökőévekkel stb.)
            int elteltNapokSzáma = (maxDátum - minDátum).Days; */

            /*f. Az OTP legrégebbi kereskedési napja: 
            DateTime optMinDátum = (from x in ticks where x.Index == "OTP" select x.TradingDay).Min(); */

            /*g. Össze is lehet kapcsolni dolgokat, ez már bonyolultabb:
            var kapcsolt =
                from
                    x in ticks
                join
                    y in Portfolio
                        on x.Index equals y.Index
                select new
                {
                    Index = x.Index,
                    Date = x.TradingDay,
                    Value = x.Price,
                    Volume = y.Volume
                };
            dataGridView1.DataSource = kapcsolt.ToList();  */


            // Var (value at risk) számítása

            //List<decimal> //ff
            Nyereségek = new List<decimal>();
            int intervalum = 30;
            DateTime kezdőDátum = (from x in ticks select x.TradingDay).Min();
            DateTime záróDátum = new DateTime(2016, 12, 30);
            TimeSpan z = záróDátum - kezdőDátum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = GetPortfolioValue(kezdőDátum.AddDays(i + intervalum))
                           - GetPortfolioValue(kezdőDátum.AddDays(i));
                Nyereségek.Add(ny);
                Console.WriteLine(i + " " + ny);
            }

            var nyereségekRendezve = (from x in Nyereségek
                                      orderby x
                                      select x)
                                        .ToList();
            MessageBox.Show(nyereségekRendezve[nyereségekRendezve.Count() / 5].ToString());

        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolio;
        }

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in ticks
                            where item.Index == x.Index.Trim()
                               && date <= x.TradingDay
                            select x)
                            .First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }

        private void btnFajlbament_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("Időszak;Nyereség");
                    int counter = 1;
                    foreach (decimal item in Nyereségek)
                    {
                        sw.WriteLine(string.Format("{0};{1}", counter, item));
                        counter++;
                    }
                }
            }
            
        }
    }
}
