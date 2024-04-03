using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] montosCompras = {
                { 150, 200, 300, 400, 500 },
                { 800, 900, 1000, 1100, 1200 },
                { 50, 60, 70, 80, 90 },
                { 1200, 1300, 1400, 1500, 1600 },
                { 950, 1050, 1150, 1250, 1350 }
            };

            CalcularDescuentos(montosCompras);
        }

        static void CalcularDescuentos(double[,] montosCompras)
        {
            int numClientes = montosCompras.GetLength(0);

            for (int cliente = 0; cliente < numClientes; cliente++)
            {
                double totalCompras = 0;

                for (int compra = 0; compra < 5; compra++)
                {
                    totalCompras += montosCompras[cliente, compra];
                }

                double descuento = 0;

                if (totalCompras >= 100 && totalCompras <= 1000)
                {
                    descuento = totalCompras * 0.10;
                }
                else if (totalCompras > 1000)
                {
                    descuento = totalCompras * 0.20;
                }

                Console.WriteLine($"Cliente {cliente + 1}: Total compras = {totalCompras:C}, Descuento = {descuento:C}");
            }
        }
    }
}