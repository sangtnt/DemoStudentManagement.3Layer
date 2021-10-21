using StudentManagement.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Entities
{
    public class Student : Person
    {
        private string _classCode;

        public string ClassCode { 
            get => _classCode; 
            set
            {
                if (value.Length <= 5)
                {
                    _classCode = value;
                }
                else
                {
                    throw new StudentException("Class code must be above 5 characters");
                }
            }
        }
        public override string ToString()
        {
            string result = $"Id: {Id} - FullName: {Fullname} - Classcode: {ClassCode}";
            return result;
        }
    }
}
