using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telapo_gyar.Abstractions;

namespace Telapo_gyar.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get;private set; }

        public Ball(Color kivantszin)
        {
            BallColor = new SolidBrush(kivantszin);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height); // kitöltött kék kört a Graphics osztály segítségével. 2. new SolidBrush(Color.Blue) helyett
        }
    }
}
