using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern
{
    public class People
    {
        private string _firstName { get; set; }
        private string _middleName { get; set; }
        private string _lastName { get; set; }
        private DateTime _dateOfBirth { get; set; }
        private string _address { get; set; }
        private string _email { get; set; }
        private string _phone { get; set; }

        public void toString()
        {
            Console.WriteLine("First name: " + _firstName);
            Console.WriteLine("Middle name: " + _middleName);
            Console.WriteLine("Last name: " + _lastName);
            Console.WriteLine("Date of Birth: " + _dateOfBirth.ToString("dd-MM-yyyy"));
            Console.WriteLine("Address: " + _address);
            Console.WriteLine("Email: " + _email);
            Console.WriteLine("Phone: " + _phone);
            Console.WriteLine("==============================");
        }

        public People()
        {

        }
        public People(string firstName, string middleName,
                        string lastName, DateTime dayofbirth,
                            string address, string email, string phone)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _dateOfBirth = dayofbirth;
            _address = address;
            _email = email;
            _phone = phone;
        }
    }
}
