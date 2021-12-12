using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telapo_gyar.Abstractions;

namespace Telapo_gyar.Entities
{
    public class BallFactory: IToyFactory
    {
        public Color BallColor { get; set; }

        public Toy CreateNew()  //függvénye CreateNew néven Ball visszatérési értékkel.A függvényben hozz létre egy Ball példányt és add vissza az értékét.
        {
            return new Ball(BallColor); 
        }
    }
}
