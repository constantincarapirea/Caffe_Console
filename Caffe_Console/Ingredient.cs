using System;
using System.Collections.Generic;
using System.Text;

namespace Caffe_Console
{
    class Ingredient
    {
        public string name_ingredient { get; set; }
        public double pice_ingredient { get; set; }

        public Ingredient(string name_ingridient,double pice_ingredient)
        {
            this.name_ingredient = name_ingridient;
            this.pice_ingredient = pice_ingredient;
        }
    }
}
