using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanFacts.Library
{
    public class Service
    {
        private readonly Repository _factRepository;

        public Service()
        {
            _factRepository = new Repository();
        }

        public string GetFact(string category = "history")
        {
            var facts = _factRepository.GetFacts();

            if (!facts.ContainsKey(category) || facts[category].Count == 0)
                return "No facts available for this category.";

            var random = new Random();
            int index = random.Next(facts[category].Count);
            return facts[category][index];
        }
    }
}
