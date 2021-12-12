using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telapo_gyar.Entities;

namespace Telapo_gyar
{
    public partial class Form1 : Form
    {
        List<Ball> _balls = new List<Ball>();
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
            _balls.Add(b); //listához adás
            b.Left = -b.Width; //Panel hozzáadás elött , (Ezzel a képernyőn kívül jön majd létre a labda)
            mainPanel.Controls.Add(b); //mainpanel vezérlőihez
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _balls)  //foreach segítségével menj végig a _balls listán és hívd meg mindegyik elemének a MoveBall metódusát
            {
                ball.MoveBall();
                if (ball.Left> maxPosition)
                {
                    maxPosition = ball.Left;
                }
            }
            if (maxPosition>1000)
            {
                var oldestBall = _balls[0];
                mainPanel.Controls.Remove(oldestBall); //levétel a panelről
                _balls.Remove(oldestBall); //levétel a listából
            }
        }
    }
}
