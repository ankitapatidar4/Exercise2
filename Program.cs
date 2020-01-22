using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age;
            int height;
            //Max Heart rate is equal to 220 - age

            age = 27;
            height = 5;

            //Console should write I am ### years old, my max heart rate is ## and I am ## feet tall

            int heart_rate;
            heart_rate = 220 - age;
            Console.WriteLine("I am " + " " + age + " " + "years old, my max heart rate is " +" "+ heart_rate + "" + "and I am " + height +" " + "feet tall");
        }
    }
}
