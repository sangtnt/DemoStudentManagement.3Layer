using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.DataAcessLayer.Contracts
{
    public interface IStudentDataAcessLayer
    {
        public bool AddStudent(Student student);
        public List<Student> GetStudents();
    }
}
