using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AbstractFactoryModalidades
{
    public class ExamenMixto : IExamen
    {
        public void AplicarExamen()
        {
            Console.WriteLine("Se aplica examen mixto (parte presencial y parte en línea).");
        }
    }
}