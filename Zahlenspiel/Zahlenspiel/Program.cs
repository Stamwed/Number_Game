using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenspiel
{
    class Program
    {

        static void Main(string[] args)

        {
            string a;
            
            do
            {
                int i;
                int z;
                

                Random rnd = new Random();
                z = rnd.Next(1, 101);

                Console.Write("Willkommen beim Zahlenspiel\nDie Regeln sind Folgende\n1. Eine Zahl von 1-100 wird automatisch erstellt und muss erraten werden\n2. Der Spieler muss seine Zahl eingeben und mit \"Enter\" bestätigen \n3. Das System gibt einen kleinen Tipp ab, bis der Spieler die Richtige Zahl erraten hat\nViel Spaß\n\n\t Bitte Zahl eingeben ");
                i = int.Parse(Console.ReadLine());


                do
                {
                    if (z < i)
                    {
                        Console.Write("\nIhre Zahl " + i + "    Die gesuchte Zahl ist kleiner als Ihre\n\n\tBitte Zahl eingeben ");
                        i = int.Parse(Console.ReadLine());
                    }
                    else if (z > i)
                    {
                        Console.Write("\nIhre Zahl " + i + "    Die gesuchte Zahl ist größer als Ihre\n\n\tBitte Zahl eingeben ");
                        i = int.Parse(Console.ReadLine());
                    }


                }
                while (i != z);
                Console.WriteLine("\nIhre Zahl " + i + " ist die richtige Zahl");
                Console.Write("\nMöchten Sie nochmal Spielen?\n\t\"y\" für ja und \"n\t\" für nein \n\tEingabe = ");
                a = Console.ReadLine();
            } while (a == "y");
        }
    }
}
