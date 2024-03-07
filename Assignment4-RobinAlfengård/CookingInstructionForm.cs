using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_RobinAlfengård
{
    public partial class CookingInstructionForm : Form
    {
        public CookingInstructionForm(Recipe recipe)
        {
            InitializeComponent();
            CookingInstructionLabel.Text = recipe.Instructions;
            IngridientsListerLabelForm3.Text = string.Join(", ", recipe.Ingridients);
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
