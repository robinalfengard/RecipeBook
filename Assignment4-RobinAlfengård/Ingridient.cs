using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_RobinAlfengård
{
    internal class Ingridient
    {
        private List<string> nameOfIngridient {  get; set; }
      

        public Ingridient(List<string> nameOfIngridient)
        {
            this.nameOfIngridient = nameOfIngridient;    
        }
    }


}
