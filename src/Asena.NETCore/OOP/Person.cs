using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asena.NETCore.OOP.p
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FatherName { get; set; }
        protected string Birthday { get; set; }
        public string Degree { set; get; }
    }
}
