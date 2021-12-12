using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telapo_gyar.Abstractions;

namespace Telapo_gyar.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color dobozColor { get; set; }
        public Color szalagColor { get; set; }

        public Toy CreateNew()
        {
        return new Present(dobozColor, szalagColor);
        }
    }
}
