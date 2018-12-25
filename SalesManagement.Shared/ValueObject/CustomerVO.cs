using System;
using System.Collections.Generic;

namespace SalesManagement.Shared.ValueObject
{
    public partial class CustomerVO
    {

        public int CustomerId { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }



    }
}
