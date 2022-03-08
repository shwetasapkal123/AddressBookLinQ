using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    public class DataManager
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Int64 PhoneNumber { get; set; }
        public Int32 zip { get; set; }
        public string Email { get; set; }       
        public string AddressBookName { get; set; }
        public string ContactType { get; set; }
    }
}
