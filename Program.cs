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

            //employee.CallMethod += new CallMethodDelegate(onCallMethod);

            employee.CallMethod += new CallMethodDelegate(onCallMethod);
            
            //calling the method of Employee class
            int employeId = employee.GetId();
            string employeeName = employee.GetName();
            string employeeDepartmentName = employee.GetDepartmentName();
            Console.WriteLine("Employee Id: " + employeId);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Employee DepartmentName: " + employeeDepartmentName);

            int updatedId = int.Parse(employee.EditDetails(employeId));
            string updatedName = employee.EditDetails();
            string updatedDepatment = employee.EditDetails(employeeDepartmentName);

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
        /*static void onCallMethod(object sender,CallMethodEventArgs args)
        {
            Console.WriteLine($"{args.methodName} method called");
        }*/
    }
}
