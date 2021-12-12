using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telapo_gyar.Abstractions;

namespace Telapo_gyar.Entities
{
    public class Present : Toy
    {
        public SolidBrush dobozColor { get; private set; }
        public SolidBrush szalagColor { get; private set; }

        public Present(Color kivantszin1,Color kivantszin2)
        {
            dobozColor = new SolidBrush(kivantszin1);
            szalagColor = new SolidBrush(kivantszin2);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(dobozColor, 0, 0, Width, Height);
            g.FillRectangle(szalagColor, 20, 0, Width/5, Height);
            g.FillRectangle(szalagColor, 0, 20, Width, Height/5);
        }
    }
}
