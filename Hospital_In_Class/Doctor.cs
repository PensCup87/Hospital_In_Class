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
            this.specialtyArea = specialtyArea;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine(specialtyArea);
        }

    }
}
