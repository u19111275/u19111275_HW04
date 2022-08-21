using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19111275_HW04.Models
{
    public class People
    {
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public string _EmailAddress { get; set; }

        public People(string name, string surname, string email)
        {
            _Name = name;
            _Surname = surname;
            _EmailAddress = email;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public string Email
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }
    }
}