using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    internal class RecipeManager
    {
        private Recipe[] listOfRecipes;
        private int numOfElements = 0;

        public RecipeManager(int maxNumOfElements)
        {
            listOfRecipes = new Recipe[maxNumOfElements];
        }

        public bool Add(Recipe recipe)
        {
            if (recipe != null)
            {
                listOfRecipes[numOfElements] = recipe;
                IncreaseNumberOfRecipeArr();
                return true;
            }
            return false;
        }

        public void Remove(Recipe recipe) 
        {
            for(int i = 0; i < listOfRecipes.Length; i++)
            {
                if (listOfRecipes[i] == recipe)
                    listOfRecipes[i] = null;
            }  
            MoveRecipesToTheLeft();
            DecreaseNumberOfRecipeArr();
        }


        public void IncreaseNumberOfRecipeArr()
        {
            numOfElements++;
        }

        public void DecreaseNumberOfRecipeArr()
        {
            numOfElements--;
        }

        public void MoveRecipesToTheLeft()
        {
            for(int i = 1; i < listOfRecipes.Length; i++)
            {
                if (listOfRecipes[i-1]  == null)
                    listOfRecipes[i-1] = listOfRecipes[i];
            }
        }

        public int GetNumberOfRecipes()
        {
            return numOfElements;
        }

        public Recipe[] GetListOfRecipes()
        {
            return listOfRecipes;
        }
    }
}
