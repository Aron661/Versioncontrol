using Mikroszimulacio10.Entities;
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

namespace Mikroszimulacio10
{
    public partial class Form1 : Form
    {
        List<Person> Population; //később példány
        List<BirthProbability> BirthProbabilities;
        List<DeathProbability> DeathProbabilities;

        Random rng = new Random(1234);

        public Form1()
        {
            InitializeComponent();
            Population = GetPopulation(@"C:\Temp\nép-teszt.csv");  //vagy @ v. \\
            BirthProbabilities = GetBirthProbabilities(@"C:\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Temp\halál.csv");
            //dataGridView1.DataSource = DeathProbabilities.ToList();

            for (int year = 2005; year <= 2024; year++)  //nem foreach mert változó alap
            {
                for (int i = 0; i < Population.Count; i++)
                {

                }
                int ferfiakszama = (from x in Population where x.Gender == Gender.Male select x).Count();
                int nokkszama = (from x in Population where x.Gender == Gender.Female select x).Count();

                Console.WriteLine(String.Format("Év: {0} Férfiak: {1} Nők: {2})",year,ferfiakszama,nokkszama ));
            }

        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> result = new List<Person>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    Person p = new Person();
                    p.BirthYear = int.Parse(items[0]);
                    p.Gender = (Gender)Enum.Parse(typeof(Gender), items[1]); // Típus kényszerítés (gender), typeof(Gender) obj
                    // p.Gender = items[1] == "1" ? Gender.Male : Gender.Female; - if kompakt alakja
                    p.NbrOfChildren = int.Parse(items[2]);

                    result.Add(p);
                }
            }

            return result;
        }
        
        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> result = new List<BirthProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    BirthProbability p = new BirthProbability();
                    p.Age = int.Parse(items[0]);
                    p.NbrOfChildren = int.Parse(items[1]);
                    p.P = double.Parse(items[2]);
                    result.Add(p);
                }
            }
            return result;
        }
        
        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> results = new List<DeathProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    DeathProbability p = new DeathProbability();
                    p.Gender = (Gender)Enum.Parse(typeof(Gender), items[0]);
                    p.Age = int.Parse(items[1]);
                    p.P = double.Parse(items[2]);
                    results.Add(p);
                }
            }
            return results;
        }

    }
}
