using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telapo_gyar.Abstractions
{
    public interface IToyFactory
    {
        Toy CreateNew(); // törzs nélküli metódus - imlementálás interfacenél
    }
}
