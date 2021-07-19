using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, double> myDictionary = new MyDictionary<string, double>();
            myDictionary.Add("Headphones", 100.99);
            myDictionary.Add("SSD", 349.99);

            Console.WriteLine(myDictionary.Lenght);
        }
    }
}
