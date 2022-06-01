using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemoHandOn
{
    public class ReflectionExample
    {
      
        public void ShowInfoOfDllFileAtRunTime()
        {
          Assembly  assembly = Assembly.LoadFrom(@"D:\aspdotnet\CSharpOPPsRepo\TestDllForTheRelection\bin\Debug\TestDllForTheRelection.dll");
            Type[] types = assembly.GetTypes();
            foreach(var t in types)
            {
                Console.WriteLine("class name.............");
                var name=t.Name; 
                Console.WriteLine(name);  
                Console.WriteLine(" method name..................");
                MethodInfo[] mis = t.GetMethods();
                foreach(MethodInfo mi in mis)
                {
                    Console.WriteLine(mi.Name);
                }
                Console.WriteLine("Proerty name.....................");
                PropertyInfo[] properties = t.GetProperties();
                foreach(PropertyInfo pi in properties)
                {
                    Console.WriteLine(pi.Name); 
                   
                }

            }
        }

    }
}
