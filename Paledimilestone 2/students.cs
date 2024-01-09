using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paledimilestone_2
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Qualification { get; set; }
        public double Fees { get; set; }

        public Student(int studentID, string name, string surname, string gender, string email, DateTime dob, string phoneNumber, string qualification)
        {
            StudentID = studentID;
            Name = name;
            Surname = surname;
            Gender = gender;
            Email = email;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Qualification = qualification;
        }

        public void CalculateFees()
        {
            //calculations to determine whether a students qualifies for a discount or not//
            Fees = Qualification == "Degree" ? 85000 : 45000;

            int age = DateTime.Now.Year - DOB.Year;
            if (DOB > DateTime.Now.AddYears(-age)) age--;

            if (age > 25)
            {
                double discount = Gender == "Female" ? 0.3 : 0.19;
                Fees = Fees - (Fees * discount);
            }
        }

        public override string ToString()
        {
            return $"ID: {StudentID}\nName: {Name} {Surname}\nGender: {Gender}\nEmail: {Email}\nDOB: {DOB.ToShortDateString()}\nPhone Number: {PhoneNumber}\nQualification: {Qualification}\nFees: R{Fees:0.00}\n";
        }
    }
}
