using System;

namespace AbstractFactoryModalidades
{
    class Program
    {
        static void Main(string[] args)
        {
            IModalidadFactory factory = new HibridaFactory();

            IGuia guia = factory.CrearGuia();
            IExamen examen = factory.CrearExamen();

            guia.MostrarGuia();
            examen.AplicarExamen();

            Console.ReadKey();
        }
    }
}