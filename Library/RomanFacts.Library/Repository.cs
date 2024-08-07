using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

                     // Not Alexandrias Library....
namespace RomanFacts.Library
{
    public class Repository
    {
        // Because MAUI execution you'll need working directory. 
        // Proper install needs different code and Directory.GetCurrentDirectory would work.
        private readonly string FactsFilePath = $"{Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)}/facts.json";

        // Facts pulled from various sources
        // https://www.britannica.com/facts/ancient-Rome
        // https://www.historyhit.com/facts-about-ancient-rome-and-the-romans/

        public Dictionary<string, List<string>> GetFacts()
        {
            if (!File.Exists(FactsFilePath))
            {
                return new Dictionary<string, List<string>>
                {
                    { "default", new List<string> { "Cannot find facts data." } }
                };
            }

            var json = File.ReadAllText(FactsFilePath);
            var facts = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json);
            return facts ?? new Dictionary<string, List<string>>
            {
                { "default", new List<string> { "Cannot find facts data." } }
            };
        }
    }
}
