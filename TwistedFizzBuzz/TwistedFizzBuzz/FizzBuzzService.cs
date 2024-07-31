using System.Collections.Generic;
using System.Linq;

namespace TwistedFizzBuzz
{
    public class FizzBuzzService
    {
        private Dictionary<int, string> _tokenMappings;
        public FizzBuzzService(Dictionary<int, string> tokenMappings) => _tokenMappings = tokenMappings;

        public List<string> GenerateFizzBuzz(int start, int end)
        {
            List<string> results = new List<string>();
            for (int i = start; i <= end; i++)
            {
                string result = "";
                foreach (var tokenMapping in _tokenMappings)
                {
                    if (i % tokenMapping.Key == 0)
                        result += tokenMapping.Value;
                }
                results.Add(string.IsNullOrEmpty(result) ? i.ToString() : result);
            }
            return results;
        }

        public List<string> GenerateFizzBuzz(IEnumerable<int> numbers)
        {
            return numbers.Select(n => GenerateFizzBuzz(n, n)
                .First())
                .ToList();
        }
    }
}
