using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Fache_KV_Tafel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] KV = new int[2, 2];
            int zaehler = 0;

            Console.Write("Zahl für A und B eingeben.\nNur die Zahlen \"0\" oder \"1\" eingeben\nZahlenreihe siehe KV ");


            Console.WriteLine("\n\n\t\t     A!       A");
            Console.WriteLine("\t\t -----------------");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t     B! |   1    |    2   |");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t\t -----------------");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t     B  |   3    |    4   |");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t\t -----------------\n\n");



            for (int i = 0; i < KV.GetLength(0); i++)
            {
                for (int j = 0; j < KV.GetLength(1);j++)
                {
                    
                    zaehler++;
                    

                    Console.Write("\n" + zaehler + ". Wert = ");
                    KV[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\n\t\t     A!       A");
            Console.WriteLine("\t\t -----------------");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t     B! |   " + KV[0, 0] + "    |   " + KV[0, 1] + "    |");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t\t -----------------");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t     B  |   " + KV[1, 0] + "    |   " + KV[1, 1] + "    |");
            Console.WriteLine("\t\t|        |        |");
            Console.WriteLine("\t\t -----------------\n");


            if (KV[0,0]==1& KV[0, 1] == 1 & KV[1, 0] == 1 & KV[1, 1] == 1  )
                Console.WriteLine("\n\tQ = Alle Möglichkeiten\n\n");
            else if (KV[0, 0] == 0 & KV[0, 1] == 0 & KV[1, 0] == 0 & KV[1, 1] == 0)
                Console.WriteLine("\n\tQ = Keine Möglichkeiten\n\n");
            else if  (KV[0,0]==1&KV[0,1]==1)
                Console.WriteLine("\n\t\tQ = B!\n\n");
            else if (KV[0, 0] == 1 & KV[1,0] == 1)
                Console.WriteLine("\n\t\tQ = A!\n\n");
            else if (KV[0, 1] == 1 & KV[1, 1] == 1)
                Console.WriteLine("\n\t\tQ = A\n\n");
            else if (KV[1, 0] == 1 & KV[1, 1] == 1)
                Console.WriteLine("\n\t\tQ = B\n\n");
            else if (KV[0, 0] == 1 & KV[1, 1] == 1)
                Console.WriteLine("\n\t\tQ = A!uB! o AuB\n\n");
            else if (KV[0, 1] == 1 & KV[1, 0] == 1)
                Console.WriteLine("\n\t\tQ = A!uB o AuB!\n\n");
           else if (KV[0, 0] == 1)
                Console.WriteLine("\n\t\tQ = A!uB!\n\n");
            else if (KV[0, 1] == 1)
                Console.WriteLine("\n\t\tQ = AuB!\n\n");
            else if (KV[1, 0] == 1)
                Console.WriteLine("\n\t\tQ = A!uB\n\n");
            else if (KV[1, 1] == 1)
                Console.WriteLine("\n\t\tQ = AuB\n\n");

            


        }
    }
}
