using System;
using System.Text;

namespace CSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please enter your name");
    string myName = Console.ReadLine();
    StringBuilder newName = new StringBuilder(myName);
    newName.Insert(0,"Hello ");
    Console.WriteLine(newName);
            }
        }
    }

