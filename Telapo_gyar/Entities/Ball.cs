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

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height); // kitöltött kék kört a Graphics osztály segítségével. 
        }
    }
}
