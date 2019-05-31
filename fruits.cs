using System;
using System.Collections.Generic;
using System.Text;

namespace fruitsHW
{
    public class fruits
    {
        public string _taste { set; get; }
        public string _color { set; get; }

        public fruits(string taste, string color)
        {
            _taste = taste;
            _color = color;
            Console.WriteLine("This is how delicious it is, mmm so  {0}", _taste);
            Console.WriteLine("What beautiful {0} color", _color);
        }

       public void fname()
        {
            Console.WriteLine("Choose your fruit?");
            string name = Console.ReadLine();
            Console.WriteLine("{0} reminds me of the sunset", name);
        }
        }
    public class Mango : fruits
    {

        public static int _weight { set; get; }
        public static int _seed { set; get; }
        public Mango (int weight, int seed, string taste, string color) : base(taste, color)
        {
            _weight = weight;
            _seed = seed;
            _taste = taste;
            _color = color;

            Console.WriteLine("Thailand's fruit are the best");
        }

        public void mangoSweetness(int sweet)
        {
            for(int i =0; i < sweet; i++)
            {
                Console.WriteLine("This is how sweet the fruit is?");

            }
        }

    }



    }
             
      