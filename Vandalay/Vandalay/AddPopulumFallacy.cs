using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeExampleLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var someProp = new Proposition() {IsTrue = true};

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


    /// <summary>
    /// Watch this will be flyby text!
    /// </summary>
    public class Proposition
    {
        public bool BelieveItToBeSo(params Person[] persons)
        {
            if (!persons.Any())
                return false;

            var countOfPeopleHere = persons.Length;

            var countOfPeopleBelieveTrue = persons.Count(p => p.BelieveToBeTrue(this));

            var isMajority = (double)countOfPeopleBelieveTrue / countOfPeopleHere > 0.5;

            return isMajority;
        }
        public bool IsTrue { get; set; }
    }

    public class Person
    {
        public virtual Predicate<Proposition> BelieveToBeTrue { get; set; } = p => false;
    }
}
