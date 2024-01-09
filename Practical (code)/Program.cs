using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        List<Paledimilestone_2.Student> students = new List<Paledimilestone_2.Student>();

        while (true)
        {
            Console.WriteLine("Welcome to Belgiumcampus student registration system.");
            Console.WriteLine("Enter '1' to register a student, '2' to display all registered students, or '3' to exit.");
            //get input from the user
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || (option != 1 && option != 2 && option != 3))
            {
                Console.WriteLine("Invalid option. Please enter '1', '2', or '3'.");
                //notifices the user that they need to selact either 1, 2, or 3 to continue//
            }

            if (option == 1)
            {
                //if the 1 is selected the programe will collect infromation from the user//
                Console.WriteLine("Enter the student's ID:");
                int studentID;
                while (!int.TryParse(Console.ReadLine(), out studentID))
                {
                    Console.WriteLine("Invalid ID. Please enter a valid integer.");
                }

                Console.WriteLine("Enter  your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter your gender (Male or Female):");
                string gender;
                while (!string.Equals((gender = Console.ReadLine()), "Male", StringComparison.OrdinalIgnoreCase) &&
                       !string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Invalid gender. Please enter 'Male' or 'Female'.");
                }

                Console.WriteLine("student's email address:");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
                DateTime dob;
                while (!DateTime.TryParse(Console.ReadLine(), out dob))
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date in the format 'YYYY-MM-DD'.");
                }
                Console.WriteLine("Enter your phone number:");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Qualification (Degree or Diploma):");
                string qualification;
                while (!string.Equals((qualification = Console.ReadLine()), "Degree", StringComparison.OrdinalIgnoreCase) &&
                       !string.Equals(qualification, "Diploma", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Invalid qualification. Please enter 'Degree' or 'Diploma'.");
                }

                Paledimilestone_2.Student student = new Paledimilestone_2.Student(studentID, name, surname, gender, email, dob, phoneNumber, qualification);
                student.CalculateFees();

                students.Add(student);

                Console.WriteLine("Registration successful.\n");
            }
            else if (option == 2)
            {
                //if 2 is selected the programe will display all the registrated students //
                Console.WriteLine("Registered Students:");

                foreach (Paledimilestone_2.Student student in students)
                {
                    Console.WriteLine(student.ToString());
                }

                Console.WriteLine();
            }
            else if (option == 3)
            {
                //if 3 is selected the program will stop//
                break;
            }
        }

        Console.WriteLine("Thank you for using the belgiumcampus registration system.");
        Console.ReadKey();
    }
}

