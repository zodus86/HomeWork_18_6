using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_18_6
{
    class ContactData
    {
        public ContactData() { }
        public ContactData(int telephonNumber, string email)
        {
            TelephonNumber = telephonNumber;
            Email = email;
        }

        public int ID { get; set; }
        public int TelephonNumber { get; set; }
        public string Email { get; set; }

    }
}
