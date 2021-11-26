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

        Excel.Application xlApp; // A Microsoft Excel alkalmazás
        Excel.Workbook xlWB; // A létrehozott munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }

        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application(); // Excel elindítása és az applikáció objektum betöltése
                xlWB = xlApp.Workbooks.Add(Missing.Value); // Új munkafüzet
                xlSheet = xlWB.ActiveSheet; // Új munkalap

                CreateTable();  // Tábla létrehozása
                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;

            }
            catch (Exception ex) //Hibakezelés a beépített hibaüzenettel
            {

                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void CreateTable()
        {
            string[] headers = new string[] {"Kód","Eladó","Oldal","Kerület","Lift","Szobák száma",
             "Alapterület (m2)",
             "Ár (mFt)",
             "Négyzetméter ár (Ft/m2)"};   //header tömb felvétele

            // xlSheet.Cells[1, 1] = headers[0]; 

            for (int i = 1; i <= headers.Length; i++) //header kiíratása
            {
                xlSheet.Cells[1, i] = headers[i - 1];
            }

            object[,] values = new object[Flats.Count, headers.Length]; //2 dimenziós tömb pédányosítása, sor lista dbszám,oszlop header hossza

            int counter = 0; //számláló a foreach ciklushoz a tömb feltöltéséhez

            foreach (Flat item in Flats)
            {
                values[counter, 0] = item.Code;
                values[counter, 1] = item.Vendor;
                values[counter, 2] = item.Side;
                values[counter, 3] = item.District;
                values[counter, 4] = item.Elevator;
                values[counter, 5] = item.NumberOfRooms;
                values[counter, 6] = item.FloorArea;
                values[counter, 7] = item.Price;
                values[counter, 8] = "="+ GetCell(counter+2,8) + "*1000000/" + GetCell(counter + 2, 7); //számított érték képlettel counter +2 tömb és excel elcsúszás miatt --pl =H2 cellában == "="+ GetCell(counter+2,8))
                counter++;
            }

            xlSheet.get_Range(
                              GetCell(2, 1),
                              GetCell(1 + values.GetLength(0),values.GetLength(1))).Value2=values;  //Range, írd ki a values tömb tartalmát az Excel fájlba.
        }

        void LoadData()
        {
            Flats = context.Flats.ToList();  //másold az adattáblát a memóriába! ToList() fv
        }

        private string GetCell(int x, int y)   //segéd fv címzéshez (0,0 -> cella A1)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }
    }
}
