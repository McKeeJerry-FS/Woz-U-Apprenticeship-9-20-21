using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Hands_On_Practice_Interface
{
    public class Cow : IMammal, IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Moo!");
        }

        public void Run()
        {
            Console.WriteLine("Cows can run at a top speed of 25 mph!");
        }

        public void Eat()
        {
            Console.WriteLine("Cows eat grass.");
        }
    }
}
