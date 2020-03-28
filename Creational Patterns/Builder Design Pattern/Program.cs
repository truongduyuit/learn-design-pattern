using System;

namespace Builder_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var people1 = new People(
                "Chung",
                "Nguyen Truong",
                "Duy",
                new DateTime(1999,10,1),
                "Dong Nai",
                "uit.truongduy@gmail.com",
                "0342525xxx"
                );

            var people2 = new PeopleBuilder()
                        .AddFirstName("Chung")
                        .AddMiddleName("Nguyen Truong")
                        .AddLastName("Duy")
                        .AddDataOfBirth(new DateTime(1999, 10, 1))
                        .AddAddress("Dong Nai")
                        .AddEmail("uit.truongduy@gmail.com")
                        .AddPhone("0342525xxx")
                        .build();

            people1.toString();
            people2.toString();

            Console.ReadKey();
        }
    }
}
