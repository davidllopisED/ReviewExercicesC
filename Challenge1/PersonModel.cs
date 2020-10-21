using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class PersonModel
    {
        string firstName, lastName;

        public PersonModel(string Name1, string Name2)
        {
            FirstName = Name1;
            LastName = Name2;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}