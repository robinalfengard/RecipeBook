using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    internal class Recipe
    {
        private string nameOfIngridient {  get; set; }
        private string instructions {  get; set; }  
        private Category category { get; set; }
        List<Ingridient> ingridients { get; set; }

        public Recipe(string nameOfIngridient, string instructions, Category category, List<Ingridient> ingridients)
        {
            this.nameOfIngridient = nameOfIngridient;
            this.instructions = instructions;
            this.category = category;
            this.ingridients = ingridients;
        }
    }


}
