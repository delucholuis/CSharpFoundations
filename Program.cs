using System;

namespace CSharpFoundations
{
    public class Parser
    {
        public static int? ParseInt(string stringToParse)
        {
           int inte;
           if (int.TryParse(stringToParse, out inte)){return inte;}
           else {return null;}
        }
    }
}
class Program 
{
    static void Main(string[] arg){
        Console.WriteLine(Parser.ParseInt("GOT"));
        
    }
}