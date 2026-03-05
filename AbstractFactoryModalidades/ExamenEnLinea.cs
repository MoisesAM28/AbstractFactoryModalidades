using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AbstractFactoryModalidades
{
    public class ExamenEnLinea : IExamen
    {
        public void AplicarExamen()
        {
            Console.WriteLine("Examen aplicado en línea.");
        }
    }
}