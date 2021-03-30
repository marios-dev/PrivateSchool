using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Trainer
    {
        private string _firstname;
        private string _lastname;
        private string _subject;
        public string FirstName
        {
            get { return _firstname; }
            private set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            private set { _lastname = value; }
        }
        public string Subject
        {
            get { return _subject; }
            private set { _subject = value; }
        }
        public Trainer()
        {
        }
        public Trainer(string firstname,string lastname,string subject)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
        }
        public override string ToString()
        {
            return $"Trainer {FirstName} {LastName} with subject {Subject} is added successfully";
        }
    }
}
