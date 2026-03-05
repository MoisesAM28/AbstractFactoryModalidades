using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModalidades
{
    public class PresencialFactory : IModalidadFactory
    {
        public IGuia CrearGuia()
        {
            return new GuiaPresencial();
        }

        public IExamen CrearExamen()
        {
            return new ExamenPresencial();
        }
    }
}