using System;

namespace Forloops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {



                //KOmmentar!!!!
                int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

                int start = (int)Math.Sqrt(x);

                for (int i = start; i > 1; i--)
                {
                    if (x % i == 0)
                    {
                        Console.WriteLine("Delbart med: " + i);
                    }
                }
            }

        }
    }
}
