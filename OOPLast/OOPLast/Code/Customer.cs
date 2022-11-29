using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLast.Code
{
    sealed class Customer : Person
    {
        public Customer(string firstName, string lastName, int teleNr) : base(firstName, lastName, teleNr)
        {

        }
    }
}
