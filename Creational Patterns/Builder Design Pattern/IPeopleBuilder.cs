using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern
{
    public interface IPeopleBuilder
    {
        PeopleBuilder AddFirstName(string firstname);
        PeopleBuilder AddMiddleName(string middlename);
        PeopleBuilder AddLastName(string lastname);
        PeopleBuilder AddDataOfBirth(DateTime dayofbirth);
        PeopleBuilder AddAddress(string address);
        PeopleBuilder AddEmail(string email);
        PeopleBuilder AddPhone(string phone);

        People build();
    }
}
