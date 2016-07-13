using Asena.NETCore.OOP.p;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asena.NETCore.OOP
{
    /// <summary>
    /// 
    /// </summary>
    public class Employee : Person
    {

        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //}
        /// <summary>
        /// 
        /// </summary>
        public string EmployeeId { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string Post { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public string Departomant { set; get; }


    }
}
