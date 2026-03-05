using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModalidades
{
    public class EnLineaFactory : IModalidadFactory
    {
        public IGuia CrearGuia()
        {
            return new GuiaEnLinea();
        }

        public IExamen CrearExamen()
        {
            return new ExamenEnLinea();
        }
    }
}