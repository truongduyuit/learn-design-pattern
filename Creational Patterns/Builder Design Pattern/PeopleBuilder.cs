using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern
{
    public class PeopleBuilder : IPeopleBuilder
    {
        private string _firstName { get; set; }
        private string _middleName { get; set; }
        private string _lastName { get; set; }
        private DateTime _dateOfBirth { get; set; }
        private string _address { get; set; }
        private string _email { get; set; }
        private string _phone { get; set; }

        public PeopleBuilder AddFirstName(string firstname)
        {
            _firstName = firstname;
            return this;
        }

        public PeopleBuilder AddLastName(string lastname)
        {
            _lastName = lastname;
            return this;
        }

        public PeopleBuilder AddMiddleName(string middlename)
        {
            _middleName = middlename;
            return this;
        }

        public PeopleBuilder AddDataOfBirth(DateTime dayofbirth)
        {
            _dateOfBirth = dayofbirth;
            return this;
        }

        public PeopleBuilder AddAddress(string address)
        {
            _address = address;
            return this;
        }

        public PeopleBuilder AddEmail(string email)
        {
            _email = email;
            return this;
        }

        public PeopleBuilder AddPhone(string phone)
        {
            _phone = phone;
            return this;
        }

        public People build()
        {
            return new People(_firstName, _middleName, _lastName, _dateOfBirth, _address, _email, _phone);
        }
    }
}
