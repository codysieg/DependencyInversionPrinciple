using System;
using System.Collections.Generic;
using System.Text;

namespace DIDataAccessLayer.Models
{
    public class Chore : IChore
    {
        public string Task { get; set; }
        public string TimeWorked { get; set; }
    }
}
