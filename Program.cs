using System.Text;

namespace BargeldRechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] geld = { "500€ Schein", "200€ Schein", "100€ Schein", "50€ Schein", "20€ Schein", "10€ Schein", "5 Schein", "2€ Münze", "1€ Münze", "50 Cent", "20 Cent", "10 Cent", "5 Cent", "2 Cent", "1 Cent" };
            int[] scheineUndMuenzen = { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            decimal gegeben;


            Console.WriteLine("Geben Sie den zu zahlenden Betrag ein: ");
            decimal betrag =Convert.ToDecimal(Console .ReadLine());

            
            while (true)
            {
                Console.WriteLine("Geben Sie den gezahlten Betrag ein: ");
                 gegeben = Convert.ToDecimal(Console.ReadLine());


                if (betrag < gegeben)
                {
                    break;
                }
                else 
                if(gegeben == betrag)
                {
                    Console.WriteLine("Der gegebene Betrag passt genau!");
                    return;
           
                }

                Console.WriteLine("Der Betrag ist zu niedrig!");

            }
            decimal ruckgeld = gegeben - betrag;
            Console.WriteLine($"Rückgeld:{ruckgeld:C}"); //mit :C währung ausgegeben wird
            //Console.WriteLine((char) 227);

            int rueckgeldInCent = (int)(ruckgeld * 100);
            //Console.WriteLine(rueckgeldInCent);

            for (int i = 0; i < scheineUndMuenzen.Length; i++) 
            { 

                int anzahl = rueckgeldInCent /scheineUndMuenzen[i];
                if(anzahl > 0)
                {
                    Console.WriteLine($"{anzahl} x {geld[i]}");
                    rueckgeldInCent = rueckgeldInCent % scheineUndMuenzen[i]; //rueckgeldInCent =% scheinUndMuenzen[i]
                }
            }

        }
    }
}
