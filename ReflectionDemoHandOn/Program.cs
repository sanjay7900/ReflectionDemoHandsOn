using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemoHandOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ReflectionExample example = new ReflectionExample(); 
            example.ShowInfoOfDllFileAtRunTime();   
            Console.ReadKey();  
        }
    }
}
