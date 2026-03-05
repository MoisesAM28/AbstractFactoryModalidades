using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AbstractFactoryModalidades
{
    public class GuiaEnLinea : IGuia
    {
        public void MostrarGuia()
        {
            Console.WriteLine("Guía en modalidad en línea.");
        }
    }
}