using System;
using System.Collections.Generic;
using System.Text;

namespace DIDataAccessLayer.Models
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
