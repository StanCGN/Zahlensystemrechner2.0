using System;

namespace Zahlensystemrechner2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich willkommen zum Zahlensystemrechner!");
            Console.WriteLine("Bitte geben sie eine Rechnung ein:");

            String Eingabe = Console.ReadLine();
            Zerlegen(Eingabe);

            Console.ReadKey();
        }

        static void Zerlegen(String Eingabe) 
        {
            int laenge = Eingabe.Length;
            PräfixErkennen(Eingabe);

            for (int zaehler = laenge; zaehler > 0; zaehler--)
            {
                
            }
        }

        static void PräfixErkennen(String Eingabe)
        {
            HexStringInInt(Eingabe);
        }

        static void HexStringInInt (String HexString)
        {
            Console.WriteLine(HexString);

            int zahl = 0;
            int laenge = HexString.Length;
            int[] hexAusdruck = new int[laenge];
            for (int zaehler = laenge; zaehler > 0; zaehler --)
            {
                Console.WriteLine(zaehler);
                char c = HexString[zaehler-1];
                if (Char.IsNumber(c))
                {
                    zahl = c - '0';
                }
                else
                {
                    switch (c)
                    {
                        case 'A':
                            zahl = 10;
                            break;
                        case 'B':
                            zahl = 11;
                            break;
                        case 'C':
                            zahl = 12;
                            break;
                        case 'D':
                            zahl = 13;
                            break;
                        case 'E':
                            zahl = 14;
                            break;
                        case 'F':
                            zahl = 15;
                            break;
                        default:
                            Console.WriteLine("Fehler!");
                            break;
                    }
                }
                Console.WriteLine(zahl);
                hexAusdruck[zaehler-1] = zahl;
            }
            HexInDez(hexAusdruck);
        }

        static void BinOktDezInInt (String Zahlenstring)
        {

        }

        static void OktInDez()
        {

        }

        static void HexInDez(int[] hexzahl)
        {

        }

        static void DezInOkt()
        {

        }

        static void DezInHex()
        {

        }
    }
}
