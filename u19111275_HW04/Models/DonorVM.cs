using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19111275_HW04.Models
{
    public class DonorVM : People
    {
        public int _Amount { get; set; }


        public DonorVM(string name, string surname, string email, int amount) : base(name, surname, email)
        {
            _Amount = amount;
        }

        public int YearsOfExperience
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
    }
}