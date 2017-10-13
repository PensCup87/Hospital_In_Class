using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class Surgeon : Doctor
    {
        protected string specialtyArea;
        protected bool operating;

        private string SpecialtyArea
        {
            get { return this.specialtyArea; }
        }

        private bool Operating
        {
            get { return this.operating; }
        }

        public Surgeon(string employeeName, int employeeNumber, bool operating, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.operating = operating;
            this.specialtyArea = specialtyArea;
        }

        public override string GetInfo()
        {
            return "Employee name: " + employeeName + " - " + "Employee Number: " + employeeNumber + " - " + "Specialty Area: " + specialtyArea + "Operating Today? " + operating;
        }

    }
}
