using System;
using System.Collections.Generic;
namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Food>  pantry = new List<Food>();
            pantry.Add(new Food("Fried Rice", 70, false, false));
            pantry.Add(new Food("Kun Pao Chicken", 35, true, true));
            pantry.Add(new Food("Sesame balls", 120, false, true));
            pantry.Add(new Food("Bobba smothy", 300, false, true));
            Buffet brazilianBuffet = new Buffet(pantry);
            Ninja black = new Ninja();
            do {
            black.Eat(brazilianBuffet.Serve());
            } while (!black.IsFull);

        }
    }
}
