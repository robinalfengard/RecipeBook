using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    internal class Ingridient
    {
        private string nameOfIngridient {  get; set; }
        private int ammount { get; set; }

        public Ingridient(string nameOfIngridient, int ammount)
        {
            this.nameOfIngridient = nameOfIngridient;
            this.ammount = ammount;
        }
    }


}
