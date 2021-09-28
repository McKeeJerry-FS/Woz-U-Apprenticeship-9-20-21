using System;

namespace DelegateTesting
{
    class Hello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello There!");
        }

        public int ScreamHello(int i)
        {
            Console.WriteLine($"HELLO THERE {i} times");
            return 2 * i;
        }
    }

    class Goodbye
    {
        public string Name { get; set; }

        public void SayGoodbye()
        {
            Console.WriteLine($"Goodbye {Name}");

        }
        public int ScreamGoodbye(int c)
        {
            Console.WriteLine($"GOODBYE {Name.ToUpper()} {c} times!");
            return 10 * c;
        }
    }

    class Ouch
    {
        public string Perp { get; set; }
        public string Victim { get; set; }

        public void SayOuch()
        {
            Console.WriteLine($"{Perp} breathes on {Victim}");
        }

        public int ScreamOuch(int count)
        {
            for (int i = 1; i < count; i++)
            {
                Console.WriteLine($"{Perp} Breathes on {Victim} time {i} of {count}");
            }
            return count;
        }
    }

    delegate void myDelegate();
    delegate int myOtherDelegate(int count);
    delegate void stillAnotherDelegate(int current, int total);
    class Program
    {
        static void Main(string[] args)
        {
            // Declare reference variables
            Hello h;
            Goodbye g1;
            Goodbye g2;
            Ouch o;

            // Step 2: Attach references to instances
            h = new Hello();
            g1 = new Goodbye();
            g2 = new Goodbye();
            o = new Ouch();

            // Step 3: Configure Instances
            g1.Name = "Brian";
            g2.Name = "Carol";
            o.Perp = "Daniel";
            o.Victim = "Lydia";

            // Step 4: Exercise the intances
            h.SayHello();
            h.ScreamHello(3);
            g1.SayGoodbye();
            g2.SayGoodbye();
            g1.ScreamGoodbye(4);
            g2.ScreamGoodbye(5);
            o.SayOuch();
            o.ScreamOuch(5);
        }
    }
}
