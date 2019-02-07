using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //cerating object of Employee class
            Employee employee = new Employee();

          

            employee.CallMethod += new CallMethodDelegate(onCallMethod);
            
            //calling the method of Employee class
            employee.GetId();
            employee.GetName();
            employee.GetDepartmentName();
           
            int updatedId = int.Parse(employee.EditDetails(employee.Id));
            string updatedName = employee.EditDetails();
            string updatedDepatment = employee.EditDetails(employee.DepartmentName);

            //printing all the value of employee details
           
            Console.WriteLine("updated name:" + updatedId);
            Console.WriteLine("updated name:" + updatedName);
            Console.WriteLine("updated department:" + updatedDepatment);


            Console.ReadKey();
        }

        static void onCallMethod(string methodname)
        {
            Console.WriteLine($"{methodname} method called");
        }
      
    }
}
