using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    internal class RecipeManager
    {
        private Recipe[] listOfRecipes;

        public RecipeManager(int maxNumOfElements)
        {
            listOfRecipes = new Recipe[maxNumOfElements];
        }
    }
}
