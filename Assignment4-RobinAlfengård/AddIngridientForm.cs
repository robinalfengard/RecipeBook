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
        private List<String> ingridientsList = new List<String>();
        public AddIngridientsForm()
        {
            InitializeComponent();
            UpdateIngridients();
        }


        private void AddIngridientsForm_Load(object sender, EventArgs e)
        {

        }


        private void AddIngridient(object sender, EventArgs e)
        {
            ingridientsList.Add(IngridientInput.Text);
            UpdateIngridients();
            IngridientInput.Text = "";
        }
        private void UpdateIngridients()
        {
            ListOfIngridientsForm2.Items.Clear();
            foreach (string ingridient in ingridientsList)
            {
                ListOfIngridientsForm2.Items.Add(ingridient + "\n");
            }
        }

        public List<string> GetIngredientsList()
        {
            return ingridientsList;
        }


        private void EditIngridient(object sender, EventArgs e)
        {

        }

        private void DeleteIngridient(object sender, EventArgs e)
        {
            String ingridientToDelete = ListOfIngridientsForm2.SelectedItems[0].Text;
            int indexOfIngridientToBeDeleted = -1;
            for(int i = 0; i< ingridientsList.Count; i++) 
            {
                if (ingridientsList[i].Equals(ingridientToDelete))
                {
                    indexOfIngridientToBeDeleted = i;
                    break;
                }
            }
            if(indexOfIngridientToBeDeleted != -1) 
            {
                ingridientsList.RemoveAt(indexOfIngridientToBeDeleted);
                UpdateIngridients();
            }

        }


        private void CancelIngridientListing(object sender, EventArgs e)
        {

        }

        private void AcceptIngridientListing(object sender, EventArgs e)
        {

        }


    }
}
