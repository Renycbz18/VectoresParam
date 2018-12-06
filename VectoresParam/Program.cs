using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            Leer(x);
            Imprimir(x);
            if (buscar(x, 15) == true)
                Console.WriteLine("\n encontrado");
            else
                Console.WriteLine("\n15 no existe");
            Console.ReadKey();
        }


        public static void Leer(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nINGRESE EL ELEMENTO {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());

            }
        }

        public static void Imprimir(int[] x)
        {
            foreach (int num in x)
            {
                Console.WriteLine("\nELEMENTO {0}", num);
            }
        }

        public static bool buscar(int[] x, int y)

        {
            bool Encontrado = false;
            foreach (int num in x)
            {
                if (num == y)
                {
                    Encontrado = true;
                    break;
                }
            }
            return Encontrado;
        }
    }
}
