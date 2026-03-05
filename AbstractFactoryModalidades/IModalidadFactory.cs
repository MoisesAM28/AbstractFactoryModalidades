using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModalidades
{
    public interface IModalidadFactory
    {
        IGuia CrearGuia();
        IExamen CrearExamen();
    }
}