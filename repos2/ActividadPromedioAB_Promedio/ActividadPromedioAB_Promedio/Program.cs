using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPromedioAB_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Seleccione una opcion\n 1- Agregar valor\n 2-Ver promedio\n 3-Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            Promedio promedio = new Promedio();
            do
            {
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese un valor");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            promedio.AgregarValor(valor);
                        }
                        break;
                    case 2:
                        {
                            promedio.CalcularPromedio();
                            double prom = promedio.CalcularPromedio();
                            Console.WriteLine("Promedio: {0}", prom);
                        }
                        break;
                }
                Console.WriteLine("Seleccione una opcion\n 1- Agregar valor\n 2-Ver promedio\n 3-Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 3);

        }
    }
}
