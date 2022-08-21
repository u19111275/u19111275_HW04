using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19111275_HW04.Models
{
    public class TeacherVM : People
    {
        public int _YearsOfExperience { get; set; }
        public string _Subject { get; set; }

        public TeacherVM( string name, string surname, string email, int years,string subject) : base(name,surname,email)
        {
            _YearsOfExperience = years;
            _Subject = subject;

        }

        public int YearsOfExperience
        {
            get { return _YearsOfExperience; }
            set { _YearsOfExperience = value; }
        }
    }
}