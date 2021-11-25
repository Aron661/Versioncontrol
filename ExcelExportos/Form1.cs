using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace ExcelExportos
{
    public partial class Form1 : Form
    {
        List<Flat> Flats;
        RealEstateEntities context = new RealEstateEntities(); //példányosítsd az ORM objektumot!

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData() 
        {
            Flats = context.Flats.ToList();  //másold az adattáblát a memóriába! ToList() fv
        }
    }
}
