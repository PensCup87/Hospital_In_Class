using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class Nurse : HospitalEmployee
    {
        private string department;
        protected int numberOfPatients;

        public string Department
        {
            get { return this.department; }
        }

        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
        }

        public Nurse()
        {

        }

        public Nurse(string employeeName, int employeeNumber, string department, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.numberOfPatients = numberOfPatients;

        }






    }
}


