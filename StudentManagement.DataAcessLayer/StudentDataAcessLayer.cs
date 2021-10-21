using StudentManagement.Entities;
using StudentManagement.Exceptions;
using System;
using System.Collections.Generic;
using StudentManagement.DataAcessLayer.Contracts;

namespace StudentManagement.DataAcessLayer
{
    public class StudentDataAcessLayer : IStudentDataAcessLayer
    {
        List<Student> students = new List<Student>();
        public bool AddStudent(Student student)
        {
            try
            {
                student.Id = Guid.NewGuid();
                students.Add(student);
                return true;
            }
            catch (StudentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
