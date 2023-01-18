using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serelization_formDemo
{
    [Serializable]//to do serelization it must to write this attribute
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Salary { get; set; } 
    }
}
