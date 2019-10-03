using System;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_calories"></param>
        /// <param name="_isSpicy"></param>
        /// <param name="_isSweet"></param>
        public Food(string _name, int _calories, bool _isSpicy, bool _isSweet){
            Name = _name;
            Calories = _calories;
            IsSpicy = _isSpicy;
            IsSweet = _isSweet;
        }
    }
}
