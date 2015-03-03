using System;
using System.Globalization;
using System.Linq;

namespace LinqBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Enumerable.Range(1, 100)
                .ToList()
                .ForEach(
                    number =>
                        Console.WriteLine(
                            (number % 3 == 0)
                                ? (number % 5 == 0) ? "FizzBuzz" : "Fizz"
                                : (number % 5 == 0) ? "Buzz" : number.ToString(CultureInfo.InvariantCulture)));
        }
    }
}