using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDllForTheRelection
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeDePartment { get; set; }
        public int EmployeeId { get; set; }
        public void EmployeeInfo()
        {
            Console.WriteLine("EmployeeId: " + EmployeeId + "\nName: " + EmployeeName + "\n" + "EmployeeDepartment: " + EmployeeDePartment);

        }





        
    }
}
