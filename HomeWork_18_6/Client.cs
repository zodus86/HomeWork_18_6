using System;

namespace HomeWork_18_6
{
    class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int ContactDataID { get; set; }

        public Client() { }
        public Client(string firstName, string lastName, string middleName, int contactDataId)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            ContactDataID = contactDataId;

        }
    }

}