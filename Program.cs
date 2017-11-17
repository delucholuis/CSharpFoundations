using System;
using System.Text;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]{"Sansa", "Bran", "Eddard", "Arya"};

          foreach (string item in names){
            Console.WriteLine(item);
          }
        }
    }
}
