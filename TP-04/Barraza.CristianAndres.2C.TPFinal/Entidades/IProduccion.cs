using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IProduccion
    {
        bool DisminuirStockPintura();
        bool DisminuirStockClavijeros();
        bool DisminuirStockCuerdas();
    }
}
