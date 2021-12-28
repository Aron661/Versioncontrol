using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;//dll using - pl: GameController class

namespace Evolucios_alg_Worldhardestgame
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;

        public Form1()
        {
            InitializeComponent();
            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);

            //gc.AddPlayer(); tesztelésre
            //gc.Start(true);
        }
    }
}
