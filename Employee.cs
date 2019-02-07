using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Employee
    {
        public int Id;
        public string Name;
        public string DepartmentName;
        public event CallMethodDelegate CallMethod;
        //public event CallMethodDelegate CallMethod;
        //public CallMethodEventArgs args = new CallMethodEventArgs();
        public Employee()
        {
            Console.WriteLine("Enter Your Id:");
            this.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Name:");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter Your Department:");
            this.DepartmentName = Console.ReadLine();
        }

        public void GetId() {

            /*args.methodName = "GetId()";
            CallMethod(this, args);*/
            CallMethod("GetId()");
            Console.WriteLine("Employee Id: " +Id);
            Console.WriteLine();
        }

        public void GetName()
        {
            /*args.methodName = "GetName()";
            CallMethod(this, args);*/
            CallMethod("GetName()");
            Console.WriteLine("Employee Name: " +Name);
            Console.WriteLine();
        }

        public void GetDepartmentName()
        {
            /*args.methodName = "GetDepartmentName()";
             CallMethod(this, args);*/
            CallMethod("GetDepartmentNmae()");
            Console.WriteLine("Employee Department Name: " +DepartmentName);
            Console.WriteLine();
        }
        public string EditDetails(int id)
        {
            Console.WriteLine("Update Your Id:");
            string updatedId= Console.ReadLine();
            return updatedId;
        }

        public string EditDetails()
        {
            Console.WriteLine("Update Your Name:");
            string updatedName = Console.ReadLine();
            return updatedName;
        }


        public string EditDetails(string Department)
        {
            Console.WriteLine("Update Your Department Name:");
            string updatedDepartment = Console.ReadLine();
            return updatedDepartment;
        }


    }
}
