using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMedidas
{
    public class Calcular
    {
        public string Posição { get; set; }
        public decimal NumeroOrigem { get; set; } = 0;

        public decimal[] Resultados;
        
        public void RealizaCalculo()
        {
            Resultados = new decimal[7];

            switch (Posição)
            {
                case "K":
                    Resultados[0] = NumeroOrigem;
                    Resultados[1] = NumeroOrigem * 10;
                    Resultados[2] = NumeroOrigem * 100;
                    Resultados[3] = NumeroOrigem * 1000;
                    Resultados[4] = NumeroOrigem * 10000;
                    Resultados[5] = NumeroOrigem * 100000;
                    Resultados[6] = NumeroOrigem * 1000000;                    
                    break;
                case "H":
                    Resultados[0] = NumeroOrigem / 10;
                    Resultados[1] = NumeroOrigem;
                    Resultados[2] = NumeroOrigem * 10;
                    Resultados[3] = NumeroOrigem * 100;
                    Resultados[4] = NumeroOrigem * 1000;
                    Resultados[5] = NumeroOrigem * 10000;
                    Resultados[6] = NumeroOrigem * 100000;
                    break;
                case "DA":
                    Resultados[0] = NumeroOrigem / 100;
                    Resultados[1] = NumeroOrigem / 10;
                    Resultados[2] = NumeroOrigem;
                    Resultados[3] = NumeroOrigem * 10;
                    Resultados[4] = NumeroOrigem * 100;
                    Resultados[5] = NumeroOrigem * 1000;
                    Resultados[6] = NumeroOrigem * 10000;
                    break;
                case "":
                    Resultados[0] = NumeroOrigem / 1000;
                    Resultados[1] = NumeroOrigem / 100;
                    Resultados[2] = NumeroOrigem / 10;
                    Resultados[3] = NumeroOrigem;
                    Resultados[4] = NumeroOrigem * 10;
                    Resultados[5] = NumeroOrigem * 100;
                    Resultados[6] = NumeroOrigem * 1000;
                    break;
                case "D":
                    Resultados[0] = NumeroOrigem / 10000;
                    Resultados[1] = NumeroOrigem / 1000;
                    Resultados[2] = NumeroOrigem / 100;
                    Resultados[3] = NumeroOrigem / 10;
                    Resultados[4] = NumeroOrigem;
                    Resultados[5] = NumeroOrigem * 10;
                    Resultados[6] = NumeroOrigem * 100;
                    break;
                case "C":
                    Resultados[0] = NumeroOrigem / 100000;
                    Resultados[1] = NumeroOrigem / 10000;
                    Resultados[2] = NumeroOrigem / 1000;
                    Resultados[3] = NumeroOrigem / 100;
                    Resultados[4] = NumeroOrigem / 10;
                    Resultados[5] = NumeroOrigem;
                    Resultados[6] = NumeroOrigem * 10;
                    break;
                case "M":
                    Resultados[0] = NumeroOrigem / 1000000;
                    Resultados[1] = NumeroOrigem / 100000;
                    Resultados[2] = NumeroOrigem / 10000;
                    Resultados[3] = NumeroOrigem / 1000;
                    Resultados[4] = NumeroOrigem / 100;
                    Resultados[5] = NumeroOrigem / 10;
                    Resultados[6] = NumeroOrigem;
                    break;
            }
        }
    }
}
