using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class Receptionist : HospitalEmployee
    {
        private string department;
        private bool onPhone;

        public string Department
        {
            get { return this.department; }
        }
        public bool OnPhone
        {
            get { return this.onPhone; }
            set { this.onPhone = value; }
        }

        public Receptionist()
        {

        }

        public Receptionist(string employeeName, int employeeNumber, string department, bool onPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.onPhone = onPhone;
        }



    }
}
