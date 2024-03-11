using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    public class Recipe
    {
        private string nameOfRecipe;
        private string instructions;
        private Category category;
        private string[] ingridients;
        private int maxNumOfIngridients;

        public Recipe(int maxNumOfIngridients)
        {
            this.maxNumOfIngridients = maxNumOfIngridients;
            ingridients = new string[maxNumOfIngridients];
        }


        public string NameOfRecipe
        {
            get { return nameOfRecipe; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("WARNING\nName of Recipe Can't Be Empty");
                }
                else
                {
                    nameOfRecipe = value;
                }
                
            }
        }

        public string Instructions
        {
            get { return instructions; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    MessageBox.Show("WARNING \n Instructions Can't Be Empty");
                }
                else
                {
                    instructions = value;
                }
                    
            }
        }

        public Category Category
        {
            get { return category; }
            set
            { category = value; }
        }

        public string[] Ingridients
        {
            get { return ingridients; }
            set
            {
                if (ingridients.Length == 0)
                {
                    MessageBox.Show("WARNING \nIngridients can't be empty");
                }
                else
                {
                    ingridients = value;
                }
            }
        }

        public int MaxNumOfIngridients
        {
            get { return maxNumOfIngridients; }
        }

        // Method to Add ingridient to first empty spot
        public void AddIngridient(String input)
        {
            Ingridients[FindFirstEmpty()] = input;
        }

        // Method to find first empty spot in array
        public int FindFirstEmpty()
        {
            for (int i = 0; i < Ingridients.Length; i++)
            {
                if (String.IsNullOrEmpty(Ingridients[i]))
                    return i;

            }
            return -1;
        }

        // Method to find number of ingridients in array - must not be null or empty string
        public int FindAmountOfIngridients()
        {
            int counter = 0;
            for (int i = 0; i < Ingridients.Length; i++)
            {
                if (!String.IsNullOrEmpty(Ingridients[i]))
                    counter++;

            }
            return counter;
        }

        // Method to delete ingridient based on string sent from addingridient form
        public void DeleteIngridient(string ingridientToDelete)
        {
            int indexOfIngredientToBeDeleted = -1;
            for (int i = 0; i < FindAmountOfIngridients(); i++)
            {
                if (Ingridients[i].Contains(ingridientToDelete))
                {
                    indexOfIngredientToBeDeleted = i;
                    break; 
                }

            }

            if (indexOfIngredientToBeDeleted != -1)
            {
                Ingridients[indexOfIngredientToBeDeleted] = null;
                MoveIngridientsToTheLeft(indexOfIngredientToBeDeleted);
            }
        }

        // Method to edit ingridient
        internal void EditIngridient(string ingridientToEdit, string newIngridient)
        {
            int indexOfIngridientToBeEdited = -1;
            for (int i = 0; i < FindAmountOfIngridients(); i++)
            {
                if (Ingridients[i].Contains(ingridientToEdit))
                    indexOfIngridientToBeEdited = i;
            }

            if (indexOfIngridientToBeEdited != -1)
            {
                Ingridients[indexOfIngridientToBeEdited] = newIngridient;
            }
        }

        // Method to move all ingridients in array to left 
        public void MoveIngridientsToTheLeft(int indexOfLatestDeletedElement)
        {

                for (int i = indexOfLatestDeletedElement; i < FindAmountOfIngridients(); i++)
                {
                    Ingridients[i] = Ingridients[i + 1];   
                }
                
        }

        // Method to retrieve only ingridients which are not empty or null
        internal string[] GetOnlySavedIngridients()
        {
            string[] arr = new string[FindAmountOfIngridients()];
            int indexOfNewArray = 0;
            for(int i = 0; i < ingridients.Length; i++)
            {
                if (!String.IsNullOrEmpty(ingridients[i]))
                {
                    arr[i] = Ingridients[i];
                    indexOfNewArray++;
                }
                    
            }
            return arr;
        }


    }
}
