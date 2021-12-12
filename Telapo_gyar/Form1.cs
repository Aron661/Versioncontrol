using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telapo_gyar.Abstractions;
using Telapo_gyar.Entities;

namespace Telapo_gyar
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        private BallFactory _ballFactory;

        public BallFactory Factory
        {
            get { return _ballFactory; }
            set { _ballFactory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();//A konstruktorban töltsd fel a Factory változót egy BallFactory példánnyal.
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Ball b = Factory.CreateNew();
            _toys.Add(b); //listához adás
            b.Left = -b.Width; //Panel hozzáadás elött , (Ezzel a képernyőn kívül jön majd létre a labda)
            mainPanel.Controls.Add(b); //mainpanel vezérlőihez
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)  //foreach segítségével menj végig a _balls(abstract előtt) listán és hívd meg mindegyik elemének a MoveBall metódusát
            {
                toy.MoveToy();
                if (toy.Left> maxPosition)
                {
                    maxPosition = toy.Left;
                }
            }
            if (maxPosition>1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy); //levétel a panelről
                _toys.Remove(oldestToy); //levétel a listából
            }
        }
    }
}
