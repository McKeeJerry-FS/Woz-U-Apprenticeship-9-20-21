using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Hands_On_Practice_Interface
{
    class Bacterium : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Bacterium eat viruses.");
        }

        public void Speak()
        {

        }

        public void Run()
        {

        }
    }
}
