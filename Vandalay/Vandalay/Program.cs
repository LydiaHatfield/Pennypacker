using System;
using System.Collections.Generic;

namespace Vandalay
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somePerson = new Person();

            bool A = somePerson.DoYouBelieveThisToBeA();

            bool B = somePerson.AMajorityBelieveThisToBe();

            bool C = somePerson.DoYouBelieveThisToBeC(B);

            bool noFallacyCommitted = A == C;
            bool fallacyCommitted = !noFallacyCommitted;

            Console.WriteLine(fallacyCommitted);
            
        }
    }
}
