using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class Doctor : HospitalEmployee
    {
        protected string specialtyArea;

        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            //set { this.specialtyArea = value; }
        }

        public Doctor()
        {
         
        }

        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

        public override string GetInfo()
        {
            return "Employee name: " + employeeName + " - " + "Employee Number: " + employeeNumber + " - " + "Specialty Area: " + specialtyArea;
        }

    }
}
