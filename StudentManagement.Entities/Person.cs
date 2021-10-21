using System;

namespace StudentManagement.Entities
{
    public abstract class Person
    {
        private Guid _Id;
        private string _fullname;

        public Guid Id { get => _Id; set => _Id = value; }
        public string Fullname { get => _fullname; set => _fullname = value; }
    }
}
