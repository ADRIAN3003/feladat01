using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat01
{
    class Program
    {
        static int[] het52 = new int[5];
        static int het;
        static void Main(string[] args)
        {
            ElsoFeladat();
            MasodikFeladat();
            HarmadikFeladat();

            Console.ReadKey();
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine("3. feladat: Kérek egy számot [1-51]: ");

            het = Convert.ToInt32(Console.ReadLine());
        }

        private static void MasodikFeladat()
        {
            for (int i = 0; i < het52.Length - 1; i++)
            {
                for (int j = i + 1; j < het52.Length; j++)
                {
                    if (het52[i] > het52[j])
                    {
                        int tmp = het52[i];
                        het52[i] = het52[j];
                        het52[j] = tmp;
                    }
                }
            }
        }

        private static void ElsoFeladat()
        {
            Console.WriteLine("1. feladat: 52 hét számai:");

            for (int i = 0; i < het52.Length; i++)
            {
                Console.WriteLine($"Kérem írja be az {i + 1}. számot: ");
                het52[i] =  Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
