using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    public class Recipe
    {
        private string nameOfRecipe;
        private string instructions;
        private Category category;
        List<String> ingridients; 

        public Recipe(string nameOfRecipe, string instructions, Category category, List<String> ingridients)
        {
            this.nameOfRecipe = nameOfRecipe;
            this.instructions = instructions;
            this.category = category;
            this.ingridients = ingridients;
        }


        public string NameOfRecipe
        {
            get { return nameOfRecipe; }
            set { nameOfRecipe = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public List<string> Ingridients
        {
            get { return ingridients; }
            set { ingridients = value; }
        }
    }


}
