using System;
using System.Linq;

namespace Vandalay
{

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
