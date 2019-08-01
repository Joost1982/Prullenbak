using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //////// Achtergrond een kleurtje geven
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.Clear();

            ///////// variabelen aanmaken
            //string karakterNaam = "Joost";
            //int leeftijd = 15;
            //Console.WriteLine("Hoihoi " + karakterNaam);
            //Console.WriteLine("Jij bent: " + leeftijd);
            //Console.WriteLine(karakterNaam.Length);

            ///////// User input
            //Console.Write("Tik je naam in: ");
            //string naampje = Console.ReadLine();
            //Console.WriteLine("Ok, hallo " + naampje);

            ///////// arrays
            //int[] nummers = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(nummers[4]);
            //nummers[4] = 999;
            //Console.WriteLine(nummers[4]);
            //string[] vrienden = new string[5]; // getal geeft aan hoeveel elementen erin komen
            //vrienden[2] = "Piet";
            //Console.WriteLine(vrienden[1]);
            //Console.WriteLine(vrienden[2]);

            //////// Methods
            //Groet("Piet", 34);
            //Groet("Kees", 999);

            /// manier 1
            //Console.WriteLine(Kwadrateer(25));
            /// manier 2
            //int gekwadrateerdgetal = Kwadrateer(25);
            //Console.WriteLine(gekwadrateerdgetal);

            ///// if statements

            //            bool isMan = true;
            //            bool isGroot = false;
            //
            //            if (isMan && isGroot)
            //            {
            //                Console.WriteLine("je bent man en groot.");
            //            } else if (isMan && !isGroot)
            //            {
            //                Console.WriteLine("je bent man, maar niet groot.");
            //            }
            //            else if (!isMan && isGroot)
            //            {
            //                Console.WriteLine("je bent geen man, wel groot.");
            //            } else
            //            {
            //                Console.WriteLine("je bent geen man en niet groot.");
            //            }

            //Spelletje();

            //Console.WriteLine(GetMax(999, 75, 10000));

            ////// rekenmachientje
            //            Console.Write("tik een nummer in: ");
            //            double num1 = Convert.ToDouble(Console.ReadLine());
            //
            //            Console.Write("tik een nummer in: ");
            //            double num2 = Convert.ToDouble(Console.ReadLine());
            //
            //            Console.Write("Operator: ");
            //            string op = Console.ReadLine();
            //
            //            if (op == "+")
            //            {
            //                Console.WriteLine(num1 + num2);
            //            } else if (op == "-")
            //            {
            //                Console.WriteLine(num1 - num2);
            //            } else if (op == "/")
            //            {
            //                Console.WriteLine(num1 / num2);
            //
            //            } else if (op == "*")
            //            {
            //                Console.WriteLine(num1 * num2);
            //            } else
            //            {
            //                Console.WriteLine("Bestaat niet.");
            //            }


            /// switch
            /// 0 --> zondag
            /// 1 --> maandag etc
            //Console.WriteLine(Dag(5));

            //// while loop
            ///
            //int index = 6;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            ////// een while loop checkt eerst de conditie en voert dan wel/niet uit
            ///// een do-while loop voert eerst eenmaal code uit en checkt daarna conditie
            ///// de code in de while loop hierboven wordt dus niet uitgevoerd en hieronder
            //// (eenmalig) wel

            //int index = 6;
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5);

            //Raadwoord();

            ////// 2 dimensional array [3 t/m x dimensional is extra ',' toevoegen
            //int[,] numberGrid =
            //{
            //    {1,2 },
            //    {2,23 },
            //    {3,8}
            //};
            //Console.WriteLine(numberGrid[2,0]); // = 3
            //Console.WriteLine(numberGrid[1,1]); // = 23


            //// error handling
            //// alles in try en catch blokken stoppen. De code die kan vastlopen
            //// stop je in de try{} en in de catch{} zet je wat die moet doen bij een vastloper


            //try {
            //    Console.WriteLine("enter a number:");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter a number:");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //
            //    Console.WriteLine(num1 / num2);
            // }

            //catch {
            //    Console.WriteLine("Fout!");
            //        }

            //of met de foutmelding erbij:
            //catch(Exception e) {
            //    Console.WriteLine("Fout: " + e );
            //        }




            //of met verschillende acties per fout
            //catch(DivideByZeroException e) {
            //    Console.WriteLine("Fout; je kan niet delen door 0: " + e);
            //        }
            //          
            //catch(FormatException e) {
            //    Console.WriteLine("Fout; verkeerde invoer: " + e);
            //        }


            //finally
            //{
            //    // alle code hierin wordt altijd uitgevoerd
            //    // maar dit is optional
            //}



            //Book boek1 = new Book() { Titel = "Bijbel" , Auteur="Piet", Paginas=100};

            Console.WriteLine(Book.bookCount);
            Book boek1 = new Book("Bijbel", "Piet", 100);
            Console.WriteLine(Book.bookCount);

            //boek1.Titel = "Boe"; // dit kan nu niet doordat de setter private is

            //Console.WriteLine(boek1.Titel);
            //Console.WriteLine(boek1.Paginas);

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.Honour());



            ///////// omdat het scherm anders meteen sluit
            Console.ReadLine();
        }

        static void Groet(string naam, int leeftijd)
        {
            Console.WriteLine("Hoooooooooooi " + naam + "!\nJij bent: " + leeftijd);
        }

        static int Kwadrateer(int getal)
        {
            int uitkomst = getal * getal;
            return uitkomst;
        }


        static void Spelletje()
        {
            Console.WriteLine("Welk getal onder de tien heb ik in gedachten?");
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            int raadgetal = 0;

            while (raadgetal != num)
            {
                               
                //raadgetal = Int32.Parse(Console.ReadLine());
                raadgetal = Convert.ToInt32(Console.ReadLine());

                if (raadgetal < num)
                {
                    Console.WriteLine("nee te laag");
                } else if (raadgetal > num)
                {
                    Console.WriteLine("nee te hoog");
                } else
                {
                    Console.WriteLine("ja goed! het was: " + num);
                }

            }
        }


        static int GetMax(int num1, int num2, int num3)
        {
            int resultaat;

            if (num1 >= num2 && num1 >= num3)
            {
                resultaat = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                resultaat = num2;
            } else
            {
                resultaat = num3;
            }

         return resultaat;
        }


        static string Dag(int dagnummer)
        {
            string dag;

            switch (dagnummer)
            {
                case 0:
                    dag = "Zondag";
                    break;
                case 1:
                    dag = "Maandag";
                    break;
                case 2:
                    dag = "Dinsdag";
                    break;
                case 3:
                    dag = "Woensdag";
                    break;
                case 4:
                    dag = "Donderdag";
                    break;
                case 5:
                    dag = "Vrijdag";
                    break;
                case 6:
                    dag = "Zaterdag";
                    break;
                default:
                    dag = "Ongeldig";
                    break;
            }

            return dag;
        }
















        static void Raadwoord()
        {
            string woord = "lolaisstout";
            char raadwoord;
            int geraden = 0;

            int lengte = woord.Length;
            string woord2 = string.Concat(Enumerable.Repeat("*", lengte));  
            StringBuilder woordx = new StringBuilder(woord2);
            woord2 = Convert.ToString(woordx);

            while (woord2 != woord && geraden != 1)
            {
                Console.WriteLine(woord2);


                Console.Write("Raad een letter (tik '!' als je het woord weet): ");
                raadwoord = Convert.ToChar(Console.ReadLine());
                

                if (raadwoord == '!') {
                    Console.WriteLine("Tik woord in: ");
                    string geradenwoord = Console.ReadLine();
                    if (geradenwoord == woord)
                    {
                        Console.WriteLine("Goed!");
                        geraden = 1;
                    } else
                    {
                        Console.WriteLine("Nope!");
                    }
                }

                //// dit werkt wel, maar niet bij de 2e positie dat een teken voor komt...
                //int pos = woord.IndexOf(raadwoord);
                //if (pos != -1)
                //{
                //    woordx[pos] = raadwoord;
                //    woord2 = Convert.ToString(woordx);
                //}
                
                // zoek alle indexes
                var gevondenIndexes = new List<int>();
                for (int i = 0; i < lengte; i++)
                    if (woord[i] == raadwoord) gevondenIndexes.Add(i);

                //gevondenIndexes.ForEach(Console.WriteLine);
                foreach (object o in gevondenIndexes)
                    woordx[Convert.ToInt32(o)] = raadwoord;
                    woord2 = Convert.ToString(woordx);
                
                if (woord2 == woord)
                {
                    Console.WriteLine("jaaaa goed!");
                }
            }
        }

    }
}
