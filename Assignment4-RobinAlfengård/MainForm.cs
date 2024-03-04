namespace Assignment4_RobinAlfengård
{
    public partial class RecipeBookWindow : Form
    {
        AddIngridientsForm addIngridientsForm = new AddIngridientsForm();

        public RecipeBookWindow()
        {
            InitializeComponent();
            CategorySelection.DataSource = Enum.GetValues(typeof(Category));
        }

        private void AddIngridientsClick(object sender, EventArgs e)
        {
            addIngridientsForm.Show();
        }

        private void AddRecipeOnClick(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe(NameOfRecipeInput.Text, InstructionsInput.Text, (Category)(CategorySelection.SelectedItem), addIngridientsForm.GetIngredientsList());
            Console.WriteLine(recipe.ToString());
        }

        private void RecipeBookWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
