using System;
using System.Text;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
           Console.WriteLine("Please enter your name");
    string myName = Console.ReadLine();
    StringBuilder newName = new StringBuilder(myName);
    newName.Insert(0,"Hello ");
    Console.WriteLine(newName);
>>>>>>> C#Exercise#3
            }
        }
    }

