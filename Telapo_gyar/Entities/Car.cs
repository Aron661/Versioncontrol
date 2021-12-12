using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telapo_gyar.Abstractions;

namespace Telapo_gyar.Entities
{
    public class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imagefajl = Image.FromFile("Images/car.png");
            g.DrawImage(imagefajl,new Rectangle(0,0,Width,Height));
        }
    }
}
