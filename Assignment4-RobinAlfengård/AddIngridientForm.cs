using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_RobinAlfengård
{
    public partial class AddIngridientsForm : Form
    {
        
        private Recipe recipe;

        public AddIngridientsForm(Recipe currentRecipe)
        {
            InitializeComponent();
            recipe = currentRecipe;
            this.AcceptButton = addIngridientButton;
            UpdateIngridients();
        }


        private void AddIngridientsForm_Load(object sender, EventArgs e)
        {
            
        }

        // Method to add ingridient
        private void AddIngridient(object sender, EventArgs e)
        {   
            if(ValidationCheck())
                recipe.AddIngridient(ingridientInput.Text);
            UpdateIngridients();
            ingridientInput.Focus();
        }


        // Method to update list of ingridients to GUI
        private void UpdateIngridients()
        {

            listOfIngridientsForm2.Items.Clear();
            foreach (string ingridient in recipe.Ingridients)
            {
                listOfIngridientsForm2.Items.Add(ingridient + "\n");
            }
            
            UpdateNumberOfIngridients();
            ingridientInput.Text = "";
        }




        // Method to update ingridient
        private void EditIngridient(object sender, EventArgs e)
        {
            if(listOfIngridientsForm2.SelectedItems.Count>0)
            {
                string ingridientToEdit = listOfIngridientsForm2.SelectedItems[0].Text.Trim();
                if(ValidationCheck())
                {
                    recipe.EditIngridient(ingridientToEdit, ingridientInput.Text);
                    UpdateIngridients();
                    ingridientInput.Text = "";
                }

            }
            else
            {
                MessageBox.Show("No Ingridient To Edit");
            }

        }


        // Method to delete ingridient 
        private void DeleteIngridient(object sender, EventArgs e)
        {
            if (listOfIngridientsForm2.SelectedItems.Count > 0)
            {
                string ingridientToDelete = listOfIngridientsForm2.SelectedItems[0].Text.Trim();
                recipe.DeleteIngridient(ingridientToDelete);
                UpdateIngridients();
            }
            else
            {
                MessageBox.Show("No Ingridient To Delete");
            }

        }

        // Method to update number of ingridients to GUI 
        private void UpdateNumberOfIngridients()
        {
            ingridientCounterLabel.Text = recipe.FindAmountOfIngridients().ToString();
        }


        // Method to cancel and delete all listed ingridients
        private void CancelIngridientListing(object sender, EventArgs e)
        {
            ClearIngridientList();
            UpdateIngridients();
        }

        // Validation to check if ingridient input is empty 
        private Boolean ValidationCheck()
        {
            if (ingridientInput.Text.Length == 0)
            {
                MessageBox.Show("Ingridient name can't be empty");
                return false;
            }
            return true;
        }

        // Helper method to clear all ingridients from list 
        private void ClearIngridientList()
        {
            for (int i = 0; i < recipe.Ingridients.Length; i++)
            {
                recipe.Ingridients[i] = null;
            }
        }

        private void AcceptIngridientListing(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
