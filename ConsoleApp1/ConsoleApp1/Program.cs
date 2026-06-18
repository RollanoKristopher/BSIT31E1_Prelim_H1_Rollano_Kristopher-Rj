using System;
using System.Collections.Generic;


class Program
{

    static string[] names = new string[100];
    static double[] grade1 = new double[100];
    static double[] grade2 = new double[100];
    static double[] grade3 = new double[100];
    static double[] averages = new double[100];
    static int studentCount = 0;



    static void Main()
    {
        int choice;
        do
        {

            Console.WriteLine("\n=====  STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\n===========================");

            Console.Write("Choose an Option: ");
            choice = Convert.ToInt32(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;


                case 3:
                    ComputeAverageGrade();
                    break;

                case 4:
                    FindHighestGrade();
                    break;

                case 5:
                    Console.WriteLine("Exiting Program.....");


                    Console.WriteLine("Goodbye!.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            } while (choice != 5) ;

        // Adding Students
            static void AddStudent()
        {
            Console.Write("Student Name: ");
            string? Name = Console.ReadLine()?? "";

            Console.Write("Grade 1: ");
            double g1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 2: ");
            double g2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Grade 3: ");
            double g3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n==========================");

            double average = (g1 + g2 + g3) / 3;

            names[studentCount] = Name;
            grade1[studentCount] = g1;
            grade2[studentCount] = g2;
            grade3[studentCount] = g3;
            averages[studentCount] = average;
            studentCount++;

            Console.WriteLine("Student added successfully!");
        }

        // View All Students
        static void ViewStudents()

        {
            if (studentCount == 0)
            {
                Console.WriteLine("No Students Found.");
                return;

            }

            Console.WriteLine("\n===== STUDENTS =====");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Name: {names[i]}");
                Console.WriteLine($"Grade 1: {grade1[i]}");
                Console.WriteLine($"Grade 2: {grade2[i]}");
                Console.WriteLine($"Grade 3: {grade3[i]}");
                Console.WriteLine($"Average: {averages[i]:F2}");
                Console.WriteLine("----------------------");
            }
        }
        //Compute Average Grade
        static void ComputeAverageGrade()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            double total = 0;

            for (int i = 0; i < studentCount; i++)
            {
                total += averages[i];
            }

            Console.WriteLine("\n===== CLASS AVERAGE =====");
            Console.WriteLine($"Overall Average Grade: {total / studentCount:F2}");
            Console.WriteLine("\n==========================");
        }

        //Finding Highest Grade
        static void FindHighestGrade()
        {
            if (studentCount == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            double highest = averages[0];
            string topStudent = names[0];

            for (int i = 1; i < studentCount; i++)
            {
                if (averages[i] > highest)
                {
                    highest = averages[i];
                    topStudent = names[i];
                }
            }

            Console.WriteLine("\n===== HIGHEST GRADE =====");
            Console.WriteLine($"Top Student: {topStudent}");
            Console.WriteLine($"Highest Grade: {highest:F2}");
            Console.WriteLine("\n==========================");
        }
    }
}