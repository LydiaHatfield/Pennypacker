using System;
using System.Collections.Generic;
using System.Text;

namespace Vandalay
{
    public class Person
    {
        public virtual bool DoYouBelieveThisToBeA()
        {
            return true;
        }

        public virtual bool DoYouBelieveThisToBeC(bool publicOpinion)
        {
            return false;
        }
    }
}
