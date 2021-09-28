using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceActivity
{
    class Mammal : Animal
    {
        public override string GiveBirth()
        {
            return "I give live birth!";
        }
    }
}
