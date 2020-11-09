using System;
using System.Collections.Generic;

namespace Vandalay
{
    class Program
    {
        static void Main(string[] args)
        {
            var someProp = new Proposition() { IsTrue = true };

            var isAdPopulumFallacy = IsAdPopulumFallacy(someProp);
            Console.WriteLine($"Is Ad Populum fallacy is '{isAdPopulumFallacy}'");
        }

        public static bool IsAdPopulumFallacy(Proposition someProposition)
        {
            var rand = new Random(DateTime.Now.Millisecond);

            var bunchOfPeople = new List<Person>();

            for (var i = 0; i < 100; i++)
            {
                var believeTrue = rand.Next() % 2 == 0;
                bunchOfPeople.Add(new Person
                {
                    BelieveToBeTrue = p => believeTrue
                });
            }

            return someProposition.BelieveItToBeSo(bunchOfPeople.ToArray()) != someProposition.IsTrue;
        }
    }
}
