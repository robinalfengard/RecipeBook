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

        // Method to add recipe 
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

        // Method to remove recipe
        public void Remove(Recipe recipe) 
        {
            int indexOfDeletedElement = -1;
            for (int i = 0; i < GetNumberOfRecipes(); i++)        
            {
                if (listOfRecipes[i] == recipe)
                {
                    listOfRecipes[i] = null;
                    indexOfDeletedElement = i;
                    MoveRecipesToTheLeft(indexOfDeletedElement);
                    DecreaseNumberOfRecipeArr();
                    break;
                }
            }


        }

        // Method to increase counter of recipes
        public void IncreaseNumberOfRecipeArr()
        {
            numOfElements++;
        }
        // Method to decrease counter of recipes
        public void DecreaseNumberOfRecipeArr()
        {
            numOfElements--;
        }

        // Method to move recipes to left
        public void MoveRecipesToTheLeft(int indexOfLatestDeletedElement)
        {
           if(indexOfLatestDeletedElement != -1)
            {
                for(int i = indexOfLatestDeletedElement; i< GetNumberOfRecipes(); i++)
                {
                    listOfRecipes[i] = listOfRecipes[i + 1];
                }
                listOfRecipes[GetNumberOfRecipes() -1]  = null;
            }   
        }

        // Method to return number of actual recipes 
        public int GetNumberOfRecipes()
        {
            return numOfElements;
        }
        // Method to return list of recipes 
        public Recipe[] GetListOfRecipes()
        {
            Recipe[] copyOfListOfRecipes = new Recipe[numOfElements]; 
            Array.Copy(listOfRecipes, copyOfListOfRecipes, numOfElements);
            return copyOfListOfRecipes;
        }
    }
}
