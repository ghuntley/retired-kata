using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        public static IFizzBuzzer FizzBuzzer { get; private set; }
        
        static void Main(string[] args)
        {
            FizzBuzzer = new FizzBuzzer();

            var numbers = Enumerable.Range(1, 100).ToList();

            numbers.ForEach(number => Console.WriteLine(FizzBuzzer.Print(number)));
        }
    }
}
