using System;
using System.Collections.Generic;

namespace Vandalay
{
    class Program2
    {
        static bool DoYouBelieveThisToBeA()
        {
            Console.WriteLine("Do you believe vaccines are effective? [Yes/No]");
            string readAnswer = Console.ReadLine();
            bool? answer = ConvertAnswer(readAnswer);

            if (answer == null)
                return DoYouBelieveThisToBeA();

            return answer.GetValueOrDefault(false);
        }

        static bool DoYouBelieveThisToBeC(bool previousAnswer)
        {
            var doOrDoNot = AMajorityBelieveThisToBe() ? "do" : "do not";
            Console.WriteLine($"The majority of people {doOrDoNot} believe vaccines are effective.");
            Console.WriteLine("Do you believe vaccines are effective? [Yes/No]");
            string readAnswer = Console.ReadLine();
            bool? answer = ConvertAnswer(readAnswer);

            if (answer == null)
                return DoYouBelieveThisToBeC(previousAnswer);

            return previousAnswer != answer.GetValueOrDefault(false);
        }

        static bool? ConvertAnswer(string readAnswer)
        {
            bool yes = string.Equals(readAnswer, "Yes", StringComparison.OrdinalIgnoreCase);
            bool no = string.Equals(readAnswer, "No", StringComparison.OrdinalIgnoreCase);

            if (yes == false && no == false)
            {
                Console.WriteLine($"'{readAnswer}' is not a valid answer!");
                return null;
            }

            return yes;
        }

        /// <summary>
        /// Survey says! a Survey company sold us this info
        /// </summary>
        public static bool AMajorityBelieveThisToBe()
        {
            return false;
        }

    }
}
