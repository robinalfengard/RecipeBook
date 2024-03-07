namespace Assignment4_RobinAlfengård
{
    public partial class RecipeBookWindow : Form
    {

        private const int MAX_NUMBER_OF_RECIPES = 200;
        private List<String> ingridients = new List<String>();
        private RecipeManager recipeManager = new RecipeManager(MAX_NUMBER_OF_RECIPES);

        public RecipeBookWindow()
        {
            InitializeComponent();
            CategorySelection.DataSource = Enum.GetValues(typeof(Category));
            ShowRecipes();
        }

        private void AddIngridientsClick(object sender, EventArgs e)
        {
            List<String> tempIngridients = new List<string>(ingridients);
            AddIngridientsForm addIngridientsForm = new AddIngridientsForm(tempIngridients);
            addIngridientsForm.ShowDialog();
            ingridients = tempIngridients;

        }

        private void AddRecipeOnClick(object sender, EventArgs e)
        {


            if (NameOfRecipe.Text.Length == 0)
            {
                MessageBox.Show("Recipe name can't be empty");
            }
            else
            {
                List<String> tempIngridients = new List<string>(ingridients);
                Recipe recipe = new Recipe(NameOfRecipeInput.Text, InstructionsInput.Text, (Category)(CategorySelection.SelectedItem), tempIngridients);
                MessageBox.Show(ingridients.Count().ToString());
                recipeManager.Add(recipe);
                NameOfRecipeInput.Text = "";
                InstructionsInput.Text = "";
                ShowRecipes();
                ingridients.Clear();
                Status();
            }
        }

        private void ShowRecipes()
        {
            ListOfRecipieNames.Clear();
            for (int i = 0; i < recipeManager.GetNumberOfRecipes(); i++)
            {
                ListOfRecipieNames.Items.Add(recipeManager.GetListOfRecipes()[i].NameOfRecipe
                                            + formatSpace() + recipeManager.GetListOfRecipes()[i].Category
                                            + formatSpace() + recipeManager.GetListOfRecipes()[i].Ingridients.Count());
            }

        }

        private void Status()
        {
            int numberOfRecipeSpacesLeft = MAX_NUMBER_OF_RECIPES - recipeManager.GetNumberOfRecipes();
            if (numberOfRecipeSpacesLeft < 10)
                MessageBox.Show("You have less than 10 spots to save recipes left, consider deleting some");

            else
            {
                MessageBox.Show("You have " + numberOfRecipeSpacesLeft.ToString() + " save spots for recipes left");
            }
        }


        private void ShowInstructions(object sender, MouseEventArgs e)
        {

            String chosenRecipe = ListOfRecipieNames.SelectedItems[0].Text;
            Recipe recipeToShowInstrcutions = ChooseRecipe(chosenRecipe);

            if (recipeToShowInstrcutions != null)
            {
                CookingInstructionForm cookingInstructionForm = new CookingInstructionForm(recipeToShowInstrcutions);
                cookingInstructionForm.ShowDialog();
            }
        }




        private void DeleteSelectedRecipe(object sender, EventArgs e)
        {
            String chosenRecipe = ListOfRecipieNames.SelectedItems[0].Text;
            Recipe recipeToDelete = ChooseRecipe(chosenRecipe);
            recipeManager.Remove(recipeToDelete);
            ShowRecipes();
        }

        private void StartEditingRecipeClick(object sender, EventArgs e)
        {
            String chosenRecipe = ListOfRecipieNames.SelectedItems[0].Text;
            Recipe recipeToEdit = ChooseRecipe(chosenRecipe);
            NameOfRecipeInput.Text = recipeToEdit.NameOfRecipe;
            CategorySelection.SelectedItem = recipeToEdit.Category;
            InstructionsInput.Text = recipeToEdit.Instructions;
            ingridients = recipeToEdit.Ingridients;
        }

        private void FinishEditRecipeClick(object sender, EventArgs e)
        {
            String chosenRecipe = ListOfRecipieNames.SelectedItems[0].Text;
            Recipe recipeToEdit = ChooseRecipe(chosenRecipe);
            List<String> tempIngridients = new List<string>(ingridients);
            recipeToEdit.NameOfRecipe = NameOfRecipeInput.Text;
            recipeToEdit.Category = (Category)CategorySelection.SelectedItem;
            recipeToEdit.Instructions = InstructionsInput.Text;
            recipeToEdit.Ingridients = tempIngridients;
            ShowRecipes();
            ResetInputFields();
        }

        private void ResetClick(object sender, EventArgs e)
        {
            ResetInputFields();
        }




        private Recipe ChooseRecipe(String chosenRecipe)
        {
            Recipe wantedRecipe = null;

            for (int i = 0; i < recipeManager.GetNumberOfRecipes(); i++)
            {
                if (chosenRecipe.Contains(recipeManager.GetListOfRecipes()[i].NameOfRecipe))
                    wantedRecipe = recipeManager.GetListOfRecipes()[i];
            }

            // handle null
            return wantedRecipe;
        }

        private void ResetInputFields()
        {
            NameOfRecipeInput.Text = "";
            CategorySelection.SelectedItem = Category.Other;
            InstructionsInput.Text = "";
            ingridients.Clear();
        }



        private String formatSpace()
        {
            return "                                                           ";
        }

        private void RecipeBookWindow_Load(object sender, EventArgs e)
        {

        }


    }


}

