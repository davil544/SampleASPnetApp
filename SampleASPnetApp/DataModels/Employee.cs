using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleASPnetApp.DataModels
{
    public class Employee
    {
        public int empID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public int taxcID { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateTerminated { get; set; }
    }
}