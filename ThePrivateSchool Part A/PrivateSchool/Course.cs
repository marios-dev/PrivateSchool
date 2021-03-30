using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Course
    {
        private string _title;
        private string _stream;
        private string _type;
        private DateTime _startdate;
        private DateTime _enddate;
        private List<Assignment> _assignment = new List<Assignment>();
        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }
        public string Stream
        {
            get { return _stream; }
            private set { _stream = value; }
        }
        public string Type
        {
            get { return _type; }
            private set { _type = value; }
        }
        public DateTime StartDate
        {
            get { return _startdate; }
            private set { _startdate = value; }
        }
        public DateTime EndDate
        {
            get { return _enddate; }
            private set { _enddate = value; }
        }
        public Course()
        {
            _assignment = new List<Assignment>();
        }
        public Course(string title,string stream, string type, DateTime startdate, DateTime enddate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startdate;
            EndDate = enddate;
            _assignment = new List<Assignment>();
        }
        public void AddAssignment(Assignment assignment)            //Για να γραφω με λιγοτερες τελειες στα ADD
        {
            _assignment.Add(assignment);
        }
        public override string ToString()
        {
            return $"Course {Title} {Stream} {Type} is valid from {StartDate} - {EndDate} is added successfully";
        }
    }
}
