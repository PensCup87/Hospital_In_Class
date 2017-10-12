using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_In_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalEmployee employee1 = new HospitalEmployee("Sour Shoes", 999);
            Doctor doc1 = new Doctor("Beetlejuice", 0, "Casual Medicine");
            Surgeon cutter = new Surgeon("Joker", 0, true, "Amputating Everything");
            Nurse nurse1 = new Nurse("Robin", 267, "Break Room", 1);
            Receptionist rec1 = new Receptionist("Crazy Alice", 4, "Smoker's Lounge", true);

            ////adding user input
            //Console.WriteLine("aSk USer");
            //string userAnswer = Console.ReadLine();

            //if(userAnswer.ToUpper() == "YES")//only if the user says yes does a new object get created
            //{
            //    Doctor variableName = new Doctor();
            //    Console.WriteLine("Do you want your doctor to practice?");
            //    string doesPractice = Console.ReadLine();
            //    if(doesPractice.ToUpper() == "YES")
            //    {
            //        doc1.Doctor = true;.....the property becomes true
            //    }
            //}


        }
    }
}
