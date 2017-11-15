using System;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value Between 5 And 20 Below");
            int myResponse = int.Parse (Console.ReadLine());

            int i=1;
            while (i <= myResponse){
                Console.WriteLine(i + (i % 2 == 0 ? " is even" :  " is odd"));
                i++;
            }
        }
    }
}
