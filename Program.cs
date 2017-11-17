using System;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal? bonus = null;
            if (bonus.HasValue)
            {
                decimal b = bonus.Value;
                System.Console.WriteLine("bonus: " + b);
            }
            else
            {
                System.Console.WriteLine("bonus: null");
            }
            bonus = 1000.00m;
            if (bonus.HasValue)
            {
                decimal b = bonus.Value;
                System.Console.WriteLine("bonus: " + b);
            }
            else
            {
                System.Console.WriteLine("bonus: null");
            }
            }
        }
    }

