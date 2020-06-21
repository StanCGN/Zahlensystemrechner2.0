using System;
using System.Collections.Generic;

namespace Zahlensystemrechner2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int DezimalZahl = Convert.ToInt32(Console.ReadLine());
            int Erg2 = Program.DezinBinär(DezimalZahl,0);
            //int BinärZahl = Convert.ToInt32(Console.ReadLine());
            //double Erg = Program.BinärinDez(0, BinärZahl);
            Console.WriteLine(Erg2);
            Console.ReadLine();

        }
        static double BinärinDez(double Erg, int BinärZahl)
        {
            var BinärStack = new Stack<int>(32);
            do
            {
                BinärStack.Push(BinärZahl % 10);
                BinärZahl /= 10;
            } while (BinärZahl != 0);
            int[] BinärArray = BinärStack.ToArray();
            int length = BinärArray.Length;
            int y = length + 1;
            while (y > 1)
            {
                for (int x = 0; x < length; x++)
                {
                    y--;
                    int i = BinärArray[y - 1];
                    Erg += i * Math.Pow(2, x);
                }
            }
            return Erg;
        }
        static int DezinBinär(int DezimalZahl, int Erg2)
        {
            List<int> DezimalList = new List<int>();
            do
            {
                DezimalList.Add(DezimalZahl % 2);
                DezimalZahl /= 2;
            } while (DezimalZahl != 0);
            int[] DezimalArray = DezimalList.ToArray();
            for (int i = 0; i < DezimalArray.Length; i++)
            {
                Erg2 += DezimalArray[i] * Convert.ToInt32(Math.Pow(10, DezimalArray.Length-i-1));
            }
            return Erg2;
        }
    }
}
