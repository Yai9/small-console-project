using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void OceniPonude(string odgovor) {
            if (odgovor.ToLower() == "da") {
                Console.WriteLine("Drago nam je da Vam se svidjaju nasi predlozi! Uzivajte na putovanju :)");
                return;
            }
            else if (odgovor.ToLower() == "ne") {
                Console.WriteLine("Zao nam je sto Vam se nasi predlozi nisu svideli. Mozda cemo imati bolje predloge u buducnosti za Vas.");
                return;
            }
        
        }

        static void Main(string[] args)
        {
            int br_putovanja = 0;
            string [] destinacije = {"Maldivi", "Kuba", "Havaji", "Kenija", "Bali", "Dubai", "Zanzibar", "Dubrovnik", "Izrael", "Kairo"};

            Console.WriteLine("Zdravo, ovo je Vas virtuelni turisticki vodic! Dacemo Vam nas predlog destinacija koje biste mogli da posetite.");
            Console.WriteLine("Unesite broj destinacija koje biste voleli da posetite ove godine:");
            br_putovanja = Convert.ToInt32(Console.ReadLine());
            if (br_putovanja <= 0) {
                Console.WriteLine("Niste uneli validnu cifru.");
                return;
            
            }
            if (br_putovanja > 10)
            {
                Console.WriteLine("Cifra ne moze biti veca od 10.");
                return;

            }
            Console.WriteLine("Izabrali smo neke destinacije za Vas:");
            for (int i = 0; i < br_putovanja; i++ )
            {
                Console.WriteLine(destinacije[i]);

               
            }
            Console.WriteLine("Da li ste zadovoljni ponudama koje ste dobili? Molimo da odgovorite sa da ili ne.");
            OceniPonude(Console.ReadLine());
        }
    }
}
