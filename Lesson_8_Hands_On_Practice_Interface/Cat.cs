using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Hands_On_Practice_Interface
{
    public class Cat : IMammal, IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }

        public void Run()
        {
            Console.WriteLine("Cats can run at a top speed of 30 mph!");
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
