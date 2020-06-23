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
            Char rechenZeichen = RechenOperation(Eingabe);
            String[] Operatoren = ZerlegenOperatoren(Eingabe);

            int[] operatorEins = InIntVerweisen(Operatoren[0]);
            int[] operatorZwei = InIntVerweisen(Operatoren[1]);
                


            Console.ReadKey();
        }

        static char RechenOperation(String Eingabe) 
        {
            char rechenzeichen = ' ';
            for (int i = 0; i < Eingabe.Length-1; i++)
            {
                if (Eingabe[i] == '+' || Eingabe[i] == '-' || Eingabe[i] == '*' || Eingabe[i] == '/' || Eingabe[i] == 'x' || Eingabe[i] == ':')
                {
                    rechenzeichen = Eingabe[i];
                    break;
                }
            }
            return rechenzeichen;
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

        static int[] InIntVerweisen(String Eingabe)
        {

            int[] rueckgabe = new int[Eingabe.Length];
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

        static int[] HexStringInInt (String HexString)
        { 
            int zahl = 0;
            int[] hexAusdruck = new int[HexString.Length];
            for (int zaehler = 0; zaehler < HexString.Length; zaehler++)
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
            return hexAusdruck;
        }

        static int[] BinOktDezInInt (String Zahlenstring)
        {
            int zahl = 0;
            int[] binOktDezAusdruck = new int[Zahlenstring.Length];
            for (int zaehler = 0; zaehler < Zahlenstring.Length; zaehler++)
            {
                char c = Zahlenstring[zaehler - 1];
                zahl = c - '0';
                binOktDezAusdruck[zaehler - 1] = zahl;
            }
            return binOktDezAusdruck;
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
