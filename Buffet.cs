using System;
using System.Collections.Generic;

namespace HungryNinja
{
class Buffet
{
    //properties
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Example", 1000, false, false)
        };
    }
    public Buffet(string _food, int _calories, bool _isSpicy, bool _isSweet)
    {
        Menu = new List<Food>()
        {
            new Food(_food, _calories, _isSpicy, _isSweet)
        };
    }

    public Buffet(List<Food> _menu)
    {
        this.Menu = _menu;
    }

    /// <summary>
    /// Method Serve
    /// </summary>
    /// <returns> Food object</returns>
    public Food Serve()
    {
        //Serve method that randomly selects a Food object from the Menu list and return the Food object.
        Food result;
        Random r = new Random();
        int  item= r.Next(0, this.Menu.Count);
        Console.WriteLine("Serving Menu item {0}:", item);
        result = this.Menu[item];
        return result;
    }
}
}
