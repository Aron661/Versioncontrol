using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telapo_gyar.Entities
{
    public class BallFactory
    {
        public Ball CreateNew()  //függvénye CreateNew néven Ball visszatérési értékkel.A függvényben hozz létre egy Ball példányt és add vissza az értékét.
        {
            return new Ball();
        }
    }
}
