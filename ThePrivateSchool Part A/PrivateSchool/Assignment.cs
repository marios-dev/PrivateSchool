using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    class Assignment
    {
        private string _title;
        private string _description;
        private DateTime _subdatetime;
        private decimal _oralmark;
        private decimal _totalmark;
        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }
        public string Description
        {
            get { return _description; }
            private set { _description = value; }
        }
        public DateTime SubDateTime
        {
            get { return _subdatetime; }
            private set { _subdatetime = value; }
        }
        public decimal OralMark
        {
            get { return _oralmark; }
            set { _oralmark = value; }
        }
        public decimal TotalMark
        {
            get { return _totalmark; }
            set { _totalmark = value; }
        }
        public Assignment()
        {
        }
        public Assignment(string title,string description,DateTime subdatetime,decimal oralmark,decimal totalmark)
        {
            Title = title;
            Description = description;
            SubDateTime = subdatetime;
            OralMark = oralmark;
            TotalMark = totalmark;
        }
        public override string ToString()
        {
            return $"Assignment {Title} , {Description} with submit date {SubDateTime} and oral / total marks {OralMark} {TotalMark} is added successfully";
        }

    }
}
