namespace Assignment4_RobinAlfengård
{
    public partial class RecipeBookWindow : Form
    {
        public RecipeBookWindow()
        {
            InitializeComponent();
            CategorySelection.DataSource = Enum.GetValues(typeof(Category));
        }


    }
}
