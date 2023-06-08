using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadPromedioAB_Promedio
{
    internal class Promedio
    {
        private double total;
        private double valor;
        private int contador;
        public void AgregarValor(double valor)
        {
            total += valor;
            contador++;
        }
        public double CalcularPromedio()
        {
            double prom;
            prom = total/contador;
            return prom;
        }
    }
}
