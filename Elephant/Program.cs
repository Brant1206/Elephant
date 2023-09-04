using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant Lucinda = new Elephant() { Name = "Lloyd", EarSize = 33 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                Console.Write("You pressed ");
                string press = Console.ReadLine();
                if (int.TryParse(press, out int value))
                {
                    if (value == 1)
                    {
                        Lloyd.WhoAmI(Lloyd.Name, Lloyd.EarSize);
                    }
                    else if (value == 2)
                    {
                        Lucinda.WhoAmI(Lucinda.Name, Lucinda.EarSize);
                    }
                    else if (value == 3)
                    {
                        Elephant Swap;
                        Swap = Lloyd;
                        Lloyd = Lucinda;
                        Lucinda = Swap;
                        Console.WriteLine("References have been swapped");
                    }
                    else return;
                }
                else return;
            }
        }
    }
}
