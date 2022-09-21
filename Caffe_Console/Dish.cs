using System;
using System.Collections.Generic;
using System.Text;

namespace Caffe_Console
{
    class Dish
    {
        public string name_food { get; set; }
        public string description { get; set; }

        public double price_food { get; set; }
        public int cooking_time {get;set;}
        
        public Dish(string name_food,double price_food,int cooking_time )
        {
            this.name_food = name_food;
            
            this.price_food = price_food;
            this.cooking_time = cooking_time; 
        }
        public override string ToString()
        {
            return $"{ name_food,20}{ price_food.ToString("##.##"),20}$ { cooking_time,15} min";
        }

    }

}
