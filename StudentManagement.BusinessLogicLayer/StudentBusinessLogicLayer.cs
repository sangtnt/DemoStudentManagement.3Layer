using StudentManagement.DataAcessLayer;
using StudentManagement.DataAcessLayer.Contracts;
using StudentManagement.Entities;
using StudentManagement.Exceptions;
using System;
using System.Collections.Generic;

namespace StudentManagement.BusinessLogicLayer
{
    public class StudentBusinessLogicLayer
    {
        private IStudentDataAcessLayer _studentDataAcessLayer;

        public StudentBusinessLogicLayer()
        {
            _studentDataAcessLayer = new StudentDataAcessLayer();
        }

        public bool AddStudent(Student student)
        {
            try
            {
                _studentDataAcessLayer.AddStudent(student);
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
            return _studentDataAcessLayer.GetStudents();
        }
    }
}
