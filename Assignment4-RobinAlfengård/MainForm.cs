namespace Assignment4_RobinAlfengård
{
    public partial class RecipeBookWindow : Form
    {

        private const int MAX_NUMBER_OF_RECIPES = 200;
        private const int MAX_NUMBER_OF_INGRIDIENTS = 50;
        private string[] ingridients = new string[MAX_NUMBER_OF_INGRIDIENTS];
        private RecipeManager recipeManager = new RecipeManager(MAX_NUMBER_OF_RECIPES);
        private Recipe currentRecipe = new Recipe(MAX_NUMBER_OF_INGRIDIENTS);


        public RecipeBookWindow()
        {
            InitializeComponent();
            categorySelection.DataSource = Enum.GetValues(typeof(Category));
            ShowRecipes();
        }

        // Add ingridient click handler - Launch AddIngridientForm
        private void AddIngridientsClick(object sender, EventArgs e)
        {
            AddIngridientsForm addIngridientsForm = new AddIngridientsForm(currentRecipe);
            addIngridientsForm.ShowDialog();
        }

        // Add recipe click handler - with error handling
        private void AddRecipeOnClick(object sender, EventArgs e)
        {
            if (nameOfRecipeInput.Text.Length == 0)
            {
                MessageBox.Show("Recipe name can't be empty");
            }
            else if (instructionsInput.Text.Length == 0)
            {
                MessageBox.Show("Recipe instructions can't be empty");
            }
            else if (currentRecipe.FindAmountOfIngridients() == 0)
            {
                MessageBox.Show("Ingridients can't be empty");
            }        
            else
            {
                currentRecipe.NameOfRecipe = nameOfRecipeInput.Text;
                currentRecipe.Instructions = instructionsInput.Text;
                currentRecipe.Category = (Category)categorySelection.SelectedItem;
                Recipe recipe = new Recipe(MAX_NUMBER_OF_INGRIDIENTS);
                recipe.NameOfRecipe = currentRecipe.NameOfRecipe;
                Array.Copy(currentRecipe.Ingridients, recipe.Ingridients, currentRecipe.Ingridients.Length);
                recipe.Instructions = currentRecipe.Instructions;
                recipe.Category = currentRecipe.Category;
                recipeManager.Add(recipe);
                nameOfRecipeInput.Text = "";
                instructionsInput.Text = "";
                ShowRecipes();
                Clear(currentRecipe.Ingridients);
                Status();
            }
        }


        // Method to show all added recipes
        private void ShowRecipes()
        {
            listOfRecipieNames.Items.Clear();

            foreach (var recipe in recipeManager.GetListOfRecipes())
            {
                if (recipe != null)
                {
                    listOfRecipieNames.Items.Add(StringToBeAddedinListBox(
                                                    recipe.NameOfRecipe,
                                                    recipe.Category.ToString(),
                                                    recipe.FindAmountOfIngridients().ToString()));
                }
            }
        }


        // Show Instructions click handler - Launch CookingInstructionsForm
        private void ShowInstructions(object sender, MouseEventArgs e)
        {
            String chosenRecipe = listOfRecipieNames.SelectedItems[0].Text;
            Recipe recipeToShowInstrcutions = ChooseRecipe(chosenRecipe);

            if (recipeToShowInstrcutions != null)
            {
                CookingInstructionForm cookingInstructionForm = new CookingInstructionForm(recipeToShowInstrcutions);
                cookingInstructionForm.ShowDialog();
            }
        }



        // Method to delete selected recipe from list of recipees
        private void DeleteSelectedRecipe(object sender, EventArgs e)
        {
            if (SelectionIsVerified(listOfRecipieNames.SelectedItems.Count))
            {
                String chosenRecipe = listOfRecipieNames.SelectedItems[0].Text;
                Recipe recipeToDelete = ChooseRecipe(chosenRecipe);
                recipeManager.Remove(recipeToDelete);
                ShowRecipes();
            }
        }


        // Event handler to start edit session for a chosen recipe on click
        private void StartEditingRecipeClick(object sender, EventArgs e)
        {
            if (SelectionIsVerified(listOfRecipieNames.SelectedItems.Count))
            {
                String chosenRecipe = listOfRecipieNames.SelectedItems[0].Text;
                Recipe recipeToEdit = ChooseRecipe(chosenRecipe);
                nameOfRecipeInput.Text = recipeToEdit.NameOfRecipe;
                categorySelection.SelectedItem = recipeToEdit.Category;
                instructionsInput.Text = recipeToEdit.Instructions;
                Array.Copy(recipeToEdit.Ingridients, currentRecipe.Ingridients, recipeToEdit.Ingridients.Length);
                editFinishButton.Enabled = true;
                clearSelectionButton.Enabled = true;
            }
        }


        // Event handler to save ingridients after edit
        private void FinishEditRecipeClick(object sender, EventArgs e)
        {
            if (SelectionIsVerified(listOfRecipieNames.SelectedItems.Count))
            {
                String chosenRecipe = listOfRecipieNames.SelectedItems[0].Text;
                Recipe recipeToEdit = ChooseRecipe(chosenRecipe);
                Array.Copy(currentRecipe.Ingridients, recipeToEdit.Ingridients, currentRecipe.Ingridients.Length);
                recipeToEdit.NameOfRecipe = nameOfRecipeInput.Text;
                recipeToEdit.Category = (Category)categorySelection.SelectedItem;
                recipeToEdit.Instructions = instructionsInput.Text;
                ShowRecipes();
                ResetInputFields();
                editFinishButton.Enabled = false;
                clearSelectionButton.Enabled = false;
            }
        }

        // Event handler on reset click
        private void ResetClick(object sender, EventArgs e)
        {
            ResetInputFields();
        }


        // Recipe selector based on name of recipe
        private Recipe ChooseRecipe(String chosenRecipe)
        {
            Recipe wantedRecipe = null;

            for (int i = 0; i < recipeManager.GetNumberOfRecipes(); i++)
            {
                if (chosenRecipe.Contains(recipeManager.GetListOfRecipes()[i].NameOfRecipe))
                     wantedRecipe = recipeManager.GetListOfRecipes()[i];
            }

            if (wantedRecipe == null)
            {
                throw new Exception("No matching recipe found"); 
            }
            return wantedRecipe;
        }

        // Helper method to reset all input fields
        private void ResetInputFields()
        {
            nameOfRecipeInput.Text = "";
            categorySelection.SelectedItem = Category.Other;
            instructionsInput.Text = "";
            Clear(ingridients);
        }

        // Helper method to reset array of strings
        private void Clear(String[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = null;
            }
        }

        // Format helper method
        private string StringToBeAddedinListBox(String name, String category, String count)
        {
            return String.Format("{0,-27} {1,-25} {2,10}  ", name, category, count);
        }

        // Warning Message
        private bool SelectionIsVerified(int potentialSelection)
        {
            if (potentialSelection == 0)
            {
                MessageBox.Show("WARNING \nList Of Recipes is Empty");
                return false;
            }
            return true;
        }

        // Information when user have less than 10 save spots left
        private void Status()
        {
            int numberOfRecipeSpacesLeft = MAX_NUMBER_OF_RECIPES - recipeManager.GetNumberOfRecipes();
            if (numberOfRecipeSpacesLeft < 10)
                MessageBox.Show("You have less than 10 spots to save recipes left, consider deleting some");
        }

        private void RecipeBookWindow_Load(object sender, EventArgs e)
        {

        }


    }


}

