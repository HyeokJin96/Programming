using System;

namespace _2023._01._02__인터페이스_
{
    public class Program
    {
        static void Main(string[] args)
        {
            car myCar = new car();
            myCar.Go();

            Sonata mySonata = new Sonata();
            mySonata.Go();

            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Yelp();

        }

    }
}
