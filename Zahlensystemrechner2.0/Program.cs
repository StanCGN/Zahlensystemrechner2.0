using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zahlensystemrechner2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int BinärZahl = Convert.ToInt32(Console.ReadLine());
            Program.BinärinDez(0,BinärZahl);

        }
        static void BinärinDez(int Erg, int BinärZahl)
        {
            //int length = 0;
            //int z;
            var BinärStack = new Stack<int>(32);
            do
            {
                BinärStack.Push(BinärZahl % 10);
                BinärZahl /= 10;
            } while (BinärZahl != 0);
            int[] BinärArray = BinärStack.ToArray();
            int length = BinärArray.Length;
            for (int y = length; y > 0; y--)
            {
                for (int x = 0; x < length-1; x++)
                {
                   int i = BinärArray[y-1];
                    Erg += i * 2 ^ x;

                }
            }
            Console.WriteLine("länge ist" + length);
            Console.WriteLine(Erg);
            Console.ReadLine();
            //return Erg;
        }
    }
}
