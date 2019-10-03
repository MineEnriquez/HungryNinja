using System;
using System.Collections.Generic;
namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        //Properties
        public bool IsFull{
            get 
            {
                bool result = true;
                if (this.calorieIntake >1200 ) 
                {
                    result = true;
                }
                else{
                    result = false;
                }
                return result;
            }
        }

        // add a constructor
        public Ninja(){
            this.calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        // add a public "getter" property called "IsFull"

        // build out the Eat method
        public void Eat(Food item)
        {
            if(this.IsFull) {
                Console.WriteLine("This ninja is full! ");
            }
            else{
                this.calorieIntake = this.calorieIntake + item.Calories;
                this.FoodHistory.Add(item);
                Console.WriteLine("       This ninja just eat: {0} which {1} spicy and {2} sweet ", item.Name, item.IsSpicy?"is":"isn't", item.IsSweet?"is":"isn't");
            }
            return;
        }
    }
}
