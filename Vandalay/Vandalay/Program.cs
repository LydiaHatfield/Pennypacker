using System;
using System.Collections.Generic;

namespace Vandalay
{
    class Program
    {
        static bool DoYouBelieveThisToBeA()
        {
            Console.WriteLine("Do you believe vaccines are effective? [Yes/No]");
            string readAnswer = Console.ReadLine();
            bool convertToBool = string.Equals(readAnswer, "Yes", StringComparison.OrdinalIgnoreCase);
            return convertToBool;
        }

        static bool DoYouBelieveThisToBeC(bool previousAnswer)
        {
            var doOrDoNot = AMajorityBelieveThisToBe() ? "do" : "do not";
            Console.WriteLine($"The majority of people {doOrDoNot} believe vaccines are effective.");
            Console.WriteLine("Do you believe vaccines are effective? [Yes/No]");
            string readAnswer = Console.ReadLine();
            bool convertToBool = string.Equals(readAnswer, "Yes", StringComparison.OrdinalIgnoreCase);

            return previousAnswer != convertToBool;
        }

        static void Main(string[] args)
        {

            bool answer = DoYouBelieveThisToBeA();
            bool fallacyCommitted = DoYouBelieveThisToBeC(answer);

            if (fallacyCommitted)
            {
                Console.WriteLine("You have committed the ad populum logical fallacy!");
            }
            else
            {
                Console.WriteLine("You have chosen correctly");
            }
        }

        /// <summary>
        /// Survey says! a Survey company sold us this info
        /// </summary>
        public static bool AMajorityBelieveThisToBe()
        {
            return true;
        }

    }
}
