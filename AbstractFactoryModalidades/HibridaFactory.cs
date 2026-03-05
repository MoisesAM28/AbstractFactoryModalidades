using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModalidades
{
    public class HibridaFactory : IModalidadFactory
    {
        public IGuia CrearGuia()
        {
            return new GuiaHibrida();
        }

        public IExamen CrearExamen()
        {
            return new ExamenMixto();
        }
    }
}