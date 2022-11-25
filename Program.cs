using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Deliverable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BuffetPrice = 9.99;
            var CoffeePrice = 2;
            var CoffeeNum = 0;
            var WaterNum = 0;
            Console.Write("Hi. welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee.\nHow many people are in your group? Please, parties of 6 or lower! ");
            int Peeps = int.Parse(Console.ReadLine());
            if (Peeps > 6)
            {
                Console.WriteLine("\nOh sorry, we can only seat parties up to 6. Have a nice day!");
            }
            else
            {
                Console.Write("A table for " + Peeps + "! Please follow me and take a seat.\nLets get everyone started with some drinks. We got water or coffee.\n");


                for (var GuestQuery = Peeps; GuestQuery > 0; GuestQuery--)
                {
                    Console.Write("\nAlright, guest " + GuestQuery + ", water or coffee? \n");
                    var GuestInput = Console.ReadLine();
                    if (GuestInput == "coffee")
                    {
                        Console.WriteLine("\n"+GuestInput + ", gotcha!\n");
                        if (GuestInput == "coffee")
                        {
                            CoffeeNum++;
                        }
                        else
                        {
                            WaterNum++;
                        }
                    }
                    else if (GuestInput == "water")
                    {
                        Console.WriteLine("\n"+GuestInput + ", got it!\n");
                        if (GuestInput == "coffee")
                        {
                            CoffeeNum++;
                        }
                        else
                        {
                            WaterNum++;
                        }
                    }
                    else 
                    {    
                        Console.Write("\nSorry, we don't carry that.\n");
                    }

                }
                var BuffetTotal = Peeps * BuffetPrice;
                var CoffeeTotal = CoffeeNum * CoffeePrice;
                var total = BuffetTotal + CoffeeTotal;

                Console.WriteLine("Alright, so thats " +CoffeeNum+ " coffess and " +WaterNum+ " waters. I'll be right back. Feel free to grab your food!\n");
                Console.WriteLine("Heres your bill! Your total is $ "+total);

            }

        }
    }

}
    









           