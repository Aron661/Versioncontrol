using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telapo_gyar.Entities
{
    public class Ball : Label
    {
        public Ball()
        {
            AutoSize = false;
            Width = Height = 50;
            Paint += Ball_Paint; // eseménykezelőt a Paint eseményéhez.
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height); // kitöltött kék kört a Graphics osztály segítségével. 
        }
        public void MoveBall()
        {
            Left++; //v. Left += 1
        }
    }
}
