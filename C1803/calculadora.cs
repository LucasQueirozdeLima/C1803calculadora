using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1803
{
    class calculadora
    {
        public double n1;
        public double n2;
        public double total;
        public int operador;
        public string verificador;

        public void calcular()
        {
            //entrada de valores
            while (verificador != "N")
            {

                Console.WriteLine("\nDigite um valor: ");
                this.n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite a operação:\n1.+\n2.-\n3.x\n4./\n ");
                this.operador = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite um valor: ");
                this.n2 = double.Parse(Console.ReadLine());

                //calculos

                if (this.operador == 1)
                {
                    total = n1 + n2;
                    Console.WriteLine("\n{0} + {1} = {2}", n1, n2, total);
                }
                if (this.operador == 2)
                {
                    total = n1 - n2;
                    Console.WriteLine("\n{0} - {1} = {2}", n1, n2, total);
                }
                if (this.operador == 3)
                {
                    total = n1 * n2;
                    Console.WriteLine("\n{0} x {1} = {2}", n1, n2, total);
                }
                if (this.operador == 4) if (this.n2 != 0)
                    {
                        total = n1 / n2;
                        Console.WriteLine("\n{0} / {1} = {2}", n1, n2, total);
                    }
                    else
                    {
                        Console.WriteLine("\nERRO!!");
                    }
                Console.WriteLine("\nVocê deseja fazer outro calculo? S/N");
                verificador = Console.ReadLine();
            }

            Console.WriteLine("Encerrando...");

        }
    }
}
