using System;

namespace fruitsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you ever taste a fruit so good it juice right out of your mouth?");
            Console.WriteLine("mmmhmmm lets take a bite into our first fruit");

            fruits F1 = new fruits("sweet", "yellow");
            F1.fname();

            Mango m1 = new Mango(1, 1, "sour", "orange");
            m1.mangoSweetness(5);

        }
    }
}
