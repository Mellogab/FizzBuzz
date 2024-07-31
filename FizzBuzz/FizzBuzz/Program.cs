using System;
using System.Collections.Generic;
using TwistedFizzBuzz;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzService(new Dictionary<int, string> { 
                { 5, "Fizz" }, 
                { 9, "Buzz" }, 
                { 27, "Bar" } 
            });

            var results = fizzBuzzService.GenerateFizzBuzz(-20, 127);
            results.ForEach(Console.WriteLine);
        }
    }
}
