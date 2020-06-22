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
            Char[] RechenOperationen = ZerlegenRechenOperationen(Eingabe);
            String[] Operatoren = ZerlegenOperatoren(Eingabe);
            
            for(int i = 0; i < Operatoren.Length - 1; i++)      // Alle zahlen von String in int Arrays umwandeln
            {
                InIntVerweisen(Operatoren[i]);
            }


            Console.ReadKey();
        }

        static Char[] ZerlegenRechenOperationen(String Eingabe)         // Zuerst wird die Rechnung nach den Operationen durchsucht und diese gespeichert
        {                                               
            int anzahl = 0;
            for (int i = 0; i < Eingabe.Length - 1; i++)                // Anzahl an Operationen wird gezählt
            {
                if (Eingabe[i] == '+' || Eingabe[i] == '-' || Eingabe[i] == '*' || Eingabe[i] == '/' || Eingabe[i] == 'x' || Eingabe[i] == ':')
                {
                    anzahl++;
                }
            }

            Char[] RechenOperationen = new Char[anzahl];                // Dann wird ein CharArray mit der passenden länge erstellt.
            anzahl = 0;
            for (int i = 0; i < Eingabe.Length - 1; i++)
            {
                if (Eingabe[i] == '+' || Eingabe[i] == '-' || Eingabe[i] == '*' || Eingabe[i] == '/' || Eingabe[i] == 'x' || Eingabe[i] == ':')
                {
                    RechenOperationen[anzahl] = Eingabe[i];
                    anzahl++;
                }
            }
            return RechenOperationen;
        }

        static String[] ZerlegenOperatoren(String Eingabe)              // Die Eingabe wird nach Zahlen aufgeteilt und diese gespeichert.
        {
            String[] Operatoren = Eingabe.Split(new Char[] {' ', '+' , '-' , '*' , '/' , 'x' , ':'});
            return Operatoren;
        }

        static int InIntVerweisen(String Eingabe)
        {
            int rueckgabe = 0;
            if (Eingabe[0]=='b'||Eingabe[0]=='B'||Eingabe[0] == 'd' || Eingabe[0] == 'D'||Eingabe[0]=='o'||Eingabe[0]=='O')
            {
                rueckgabe = BinOktDezInInt(Eingabe);   
            }
            else if (Eingabe[0] == 'h' || Eingabe[0] == 'H')
            {
                rueckgabe = HexStringInInt(Eingabe);
            }
            else
            {
                Console.WriteLine("Error!");
            }

            return rueckgabe;
        }

        static int HexStringInInt (String HexString)
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
                return zahl;
            }
            HexInDez(hexAusdruck);
        }

        static int BinOktDezInInt (String Zahlenstring)
        {
            return 0;
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
