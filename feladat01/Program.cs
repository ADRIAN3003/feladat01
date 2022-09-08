using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace feladat01
{
    class Program
    {
        static int[] het52 = new int[5];
        static int het;
        static string[] hetek = new string[51];
        static int[] huzott = new int[91];
        static void Main(string[] args)
        {
            ElsoFeladat();
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();

            Console.ReadKey();
        }

        private static void HatodikFeladat()
        {
            Console.Write($"\n6. feladat: Páratlan számok kihúzva: ");
            int paratlan = 0;
            for (int i = 0; i < huzott.Length; i++)
            {
                if (i % 2 != 0)
                {
                    paratlan += huzott[i];
                }
            }

            Console.WriteLine(paratlan);
        }

        private static void OtodikFeladat()
        {
            Console.Write($"\n5. feladat: Egyszer sem húztak ki: ");

            HuzottSzamokFeltoltese();

            EldontesKiNemHuzottSzam();
        }

        private static void EldontesKiNemHuzottSzam()
        {
            int j = 1;
            while (j < 91 && huzott[j] != 0)
            {
                j++;
            }

            if (j < 91)
            {
                Console.WriteLine("Van");
            }
            else
            {
                Console.WriteLine("Nincs");
            }
        }

        private static void HuzottSzamokFeltoltese()
        {
            for (int i = 0; i < 51; i++)
            {
                string[] szamok = hetek[i].Split();

                foreach (string szam in szamok)
                {
                    huzott[Convert.ToInt32(szam)]++;
                }
            }
        }

        private static void NegyedikFeladat()
        {
            AdatokBeolvasasa();
            AdottHetKiirasa(het);
        }

        private static void AdottHetKiirasa(int het)
        {
            Console.WriteLine($"\n4. feladat: {het}. hét számai: {hetek[het - 1]}");
        }

        private static void AdatokBeolvasasa()
        {
            StreamReader be = new StreamReader("lottosz.dat");

            int i = 0;
            while (!be.EndOfStream)
            {
                hetek[i++] = be.ReadLine();
            }

            be.Close();
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
