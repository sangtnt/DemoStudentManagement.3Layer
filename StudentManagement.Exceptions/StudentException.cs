using System;

namespace StudentManagement.Exceptions
{
    public class StudentException : ApplicationException
    {
        public StudentException(string message) : base(message)
        {
        }

    }
}
