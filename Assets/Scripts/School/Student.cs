using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using JetBrains.Annotations;

namespace RC3Student
{
    public class Student
    {
        public string FirstName;
        private string MiddleName;
        public string LastName;

        private int age;
        private string HomeCountry;

        public Student(string _firstName, string _middleName, string _lastName, int _age, string _homeCountry)
        {
            FirstName = _firstName;
            MiddleName = _middleName;
            LastName = _lastName;
            age = _age;
            HomeCountry = _homeCountry;

        }
        public string GetstudentName()


        {
            return FirstName+LastName;
        }

    }
}
