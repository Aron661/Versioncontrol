using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telapo_gyar.Abstractions
{
    public abstract class Toy:Label   //absztrakt osztály képzése
    {
        public Toy()
        {
            AutoSize = false;
            Width = Height = 50;
            Paint += Toy_Paint; // eseménykezelőt a Paint eseményéhez.
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g); //absztrakt metódus - törzs nélkül + ;, ezután lehet a Graphics-nak a using System.Drawing;

        public virtual void MoveToy() //virtual - Ez annyiban különbözik az absztrakt elemektől, hogy alapvetően ki van fejtve, és önmagában is használható, de lehetőséget ad arra, hogy a leszármazott osztályban felülírjuk az adott függvény működését
        {
            Left++; //v. Left += 1
        }
    }
}
