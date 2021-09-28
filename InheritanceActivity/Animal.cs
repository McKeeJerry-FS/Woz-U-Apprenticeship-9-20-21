using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceActivity
{
    class Animal
    {
        public virtual string GiveBirth()
        {
            return "I don't know how.";
        }

        public Animal(string name, string birthMethod)
        {
            this.name = name;
            this.birthMethod = birthMethod;

            public string GiveBirth()
            {

            }
        }
    }
}
