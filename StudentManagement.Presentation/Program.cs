using StudentManagement.BusinessLogicLayer;
using StudentManagement.Entities;
using StudentManagement.Exceptions;
using System;
using System.Collections.Generic;

namespace StudentManagement.Presentation
{
    class Program
    {
        static StudentBusinessLogicLayer _studentBusinessLogicLayer = new StudentBusinessLogicLayer();
        static void Main(string[] args)
        {
            Console.Write("Enter fullname: ");
            string fullname = Console.ReadLine();
            Console.Write("Enter class code: ");
            string classCode = Console.ReadLine();

            try
            {
                Student student = new Student()
                {
                    Fullname = fullname,
                    ClassCode = classCode
                };
                if (_studentBusinessLogicLayer.AddStudent(student))
                {
                    Console.WriteLine("Adding successfully!");
                }
                Console.WriteLine(new string('-', 30));
                List<Student> students = _studentBusinessLogicLayer.GetStudents();
                students.ForEach(item =>
                {
                    Console.WriteLine(item.ToString());
                });
            }
            catch(StudentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
