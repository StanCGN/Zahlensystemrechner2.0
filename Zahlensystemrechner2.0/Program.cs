using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Zahlensystemrechner2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int BinärZahl = Convert.ToInt32(Console.ReadLine());
            double Erg = Program.BinärinDez(0,BinärZahl);
            Console.WriteLine(Erg);
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
            int y = length+1;
            while (y > 1)
            {
                for (int x = 0; x < length; x++)
                {
                    y--;
                    int i = BinärArray[y - 1];
                    Erg += i * Math.Pow(2,x);
                }
            }
            return Erg;
        }
    }
}
