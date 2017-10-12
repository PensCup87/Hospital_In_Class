using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class Surgeon : Doctor
    {
        protected bool operating;

        private bool Operating
        {
            get { return this.operating; }
        }

        public Surgeon(string employeeName, int employeeNumber, bool operating)
        {
            this.operating = operating;
        }
    }
}
