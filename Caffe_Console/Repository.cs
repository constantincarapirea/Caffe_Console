using System;
using System.Collections.Generic;
using System.Text;

namespace Caffe_Console
{
    class Repository
    {
        static readonly string[] Name;
        static readonly string[] name_food;
        static readonly double[] price_food;
        static readonly int[] cooking_time;
        static readonly string[] name_ingredient;
        static readonly double[] price_ingredient;
        static Random random;

        static Repository()
        {

            random= new Random();
            Name = new string[]
            {
                "Mihai",
                "Ion",
                "Vladislav",
                "Roman",
                "Dan",
                "Maria",
                "Elena",
                "Constantin",
            };
            name_food = new string[]
            {
                "Vegetabel Omelette",
                "Capprese Salad",
                "Salmon Salad",
                "Beef salad",
                "Shrimp Caesar",
                "Meatballs",
            };
           price_food = new double[]
            {
                11.50,
                18.32,
                29.18,
                13.78,
                50.42,
                19.72,

            };
            cooking_time = new int[]
          {
                30,
                45,
                18,
                25,
                28,
                29,

          };
        
            name_ingredient = new string[]
            {
                "egg",
                "tomatoes",
                "cabbage",
                "carrot",
                "leek",
                "potato",
                "spinach",
                "Parsley",
            };
           price_ingredient = new double[]
            {
                11.50,
                18.32,
                29.18,
                13.78,
                50.42,
                19.72,

            };
          
        }
        public List<Dish> Dishes { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Cook>Cooks{get;set;}
        
       
        public Repository(int Count)
        {
            this.Dishes = new List<Dish>();
            for (int i = 0; i < Count; i++)
            {
                this.Dishes.Add(
                    new Dish(
                      name_food[Repository.random.Next(Repository.name_food.Length)],
                      price_food[Repository.random.Next(Repository.price_food.Length)],
                      cooking_time[Repository.random.Next(Repository.cooking_time.Length)]
                        ));
            }
            this.Ingredients = new List<Ingredient>();
            for (int i = 0; i < Count; i++)
            {
                this.Ingredients.Add(
                    new Ingredient(
                      name_ingredient[Repository.random.Next(Repository.name_ingredient.Length)],
                      price_ingredient[Repository.random.Next(Repository.price_ingredient.Length)]
                                  ));
                   }
            this.Cooks = new List<Cook>();
            for (int i = 0; i < Count; i++)
            {
                this.Cooks.Add(
                    new Cook(
                      Name[Repository.random.Next(Repository.Name.Length)]
                               ));
            }
        }
       
        public void Print(string Text)
        {
            Console.WriteLine(Text);
            Console.WriteLine($"{"Name food",20}{"Price food",20}{"Cooking time",15}\n");
            foreach (var dish in Dishes)
            {
                Console.WriteLine(dish);
            }
        }
    }
}
