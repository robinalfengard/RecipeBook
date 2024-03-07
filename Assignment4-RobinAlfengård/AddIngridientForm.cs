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
    public partial class AddIngridientsForm : Form
    {
        private List<String> ingridientsList;
        private const int MAX_NUMBER_OF_INGRIDIENTS = 50;

        public AddIngridientsForm(List<String> listOfIngridients)
        {
            InitializeComponent();
            ingridientsList = listOfIngridients;
            UpdateIngridients();
        }


        private void AddIngridientsForm_Load(object sender, EventArgs e)
        {

        }


        private void AddIngridient(object sender, EventArgs e)
        {   
            if(ValidationCheck())
                ingridientsList.Add(IngridientInput.Text);
            UpdateIngridients();
            UpdateNumberOfIngridients();
            IngridientInput.Text = "";
        }
        private void UpdateIngridients()
        {
            ListOfIngridientsForm2.Items.Clear();
            foreach (string ingridient in ingridientsList)
            {
                ListOfIngridientsForm2.Items.Add(ingridient + "\n");
            }
            UpdateNumberOfIngridients();
        }

        public List<string> GetIngredientsList()
        {
            return ingridientsList;
        }


        private void EditIngridient(object sender, EventArgs e)
        {
            string ingridientToEdit = ListOfIngridientsForm2.SelectedItems[0].Text.Trim();
            int indexOfIngridientToBeEdited = ingridientsList.FindIndex(ingridient => ingridient.Equals(ingridientToEdit));


            if (indexOfIngridientToBeEdited != -1)
            {
                ingridientsList[indexOfIngridientToBeEdited] = IngridientInput.Text;
                if(ValidationCheck())
                    UpdateIngridients();
                IngridientInput.Text = "";
            }

        }

        private void DeleteIngridient(object sender, EventArgs e)
        {
            if (ListOfIngridientsForm2.SelectedItems.Count > 0)
            {
                string ingridientToDelete = ListOfIngridientsForm2.SelectedItems[0].Text.Trim();
                int indexOfIngridientToBeDeleted = ingridientsList.FindIndex(ingridient => ingridient.Equals(ingridientToDelete));

                if (indexOfIngridientToBeDeleted != -1)
                {
                    ingridientsList.RemoveAt(indexOfIngridientToBeDeleted);
                    UpdateIngridients();
                }
            }
        }

        private void UpdateNumberOfIngridients()
        {
            IngridientCounterLabel.Text = ingridientsList.Count.ToString();
        }


        private void CancelIngridientListing(object sender, EventArgs e)
        {
            ingridientsList.Clear();
            UpdateIngridients();

        }

        private Boolean ValidationCheck()
        {
            if (IngridientInput.Text.Length == 0)
            {
                MessageBox.Show("Ingridient name can't be empty");
                return false;
            }
            if(ingridientsList.Count == MAX_NUMBER_OF_INGRIDIENTS)
            {
                MessageBox.Show("Max number of ingridients exceeded, consider removing some");
                return false;
            }

            return true;
        }

        private void AcceptIngridientListing(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
