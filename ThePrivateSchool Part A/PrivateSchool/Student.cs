using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Student
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dateofbirth;
        private decimal _tuitionfees;
        private List<Assignment> _assignment = new List<Assignment>();
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname;}
            private set { _lastname = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateofbirth; }
            private set { _dateofbirth = value; }
        }
        public decimal TuitionFees
        {
            get { return _tuitionfees; }
            private set { _tuitionfees = value; }
        }
        public Student()
        {
            _assignment = new List<Assignment>();
        }
        public Student(string firstname,string lastname,DateTime dateofbirth,decimal tuitionfees)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            TuitionFees = tuitionfees;
            _assignment = new List<Assignment>();
        }
        public override string ToString()
        {
            return $"Student {FirstName} {LastName} with date of birth {DateOfBirth} and fees {TuitionFees} is added successfully";
        }
    }
}
