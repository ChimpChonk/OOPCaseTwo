using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLast.Code
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeleNr { get; set; }

        public Person(string firstName, string lastName, int teleNr)
        {
            FirstName = firstName;
            LastName = lastName;
            TeleNr = teleNr;
        }


    }
}
