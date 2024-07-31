using System;
using System.Collections.Generic;
using TwistedFizzBuzz;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzServiceTests
    {
        [Fact]
        public void Generates_Correct_FizzBuzz_For_Standard_Range()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService(new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });
            var expectedResult = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(1, 15);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Generates_Correct_FizzBuzz_For_Custom_Tokens_And_Divisors()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService(new Dictionary<int, string> { { 4, "Quad" }, { 7, "Sept" } });
            var expectedResult = new List<string> { "1", "2", "3", "Quad", "5", "6", "Sept", "Quad", "9", "10", "11", "Quad", "13", "Sept", "15", "Quad" };

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(1, 16);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Generates_Correct_FizzBuzz_For_Non_Sequential_Numbers()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService(new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });
            var numbers = new List<int> { -5, 0, 6, 9, 10, 15 };
            var expectedResult = new List<string> { "Buzz", "FizzBuzz", "Fizz", "Fizz", "Buzz", "FizzBuzz" };

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(numbers);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Handles_Empty_Input_And_Returns_Empty_List()
        {
            // Arrange
            var fizzBuzzService = new FizzBuzzService(new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } });

            // Act
            var result = fizzBuzzService.GenerateFizzBuzz(new List<int>());

            // Assert
            Assert.Empty(result);
        }
    }
}
