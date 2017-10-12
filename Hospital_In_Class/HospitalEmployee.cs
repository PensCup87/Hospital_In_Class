using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class HospitalEmployee
    {
        protected string employeeName;
        protected int employeeNumber;

        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }

        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
            set { this.employeeNumber = value; }
        }

        public HospitalEmployee()
        {

        }

        public HospitalEmployee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }

        public virtual void GetInfo()
        {
            Console.Write("Employee Name " + employeeName + " " + employeeNumber);
        }
            
    }
}
