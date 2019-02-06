using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Employee
    {
        int Id;
        string Name;
        string DepartmentName;
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

        public int GetId() {

            /*args.methodName = "GetId()";
            CallMethod(this, args);*/
            CallMethod("GetId()");
            return Id;
        }

        public string GetName()
        {
            /*args.methodName = "GetName()";
            CallMethod(this, args);*/
            CallMethod("GetName()");
            return Name;
        }

        public string GetDepartmentName()
        {
            /*args.methodName = "GetDepartmentName()";
             CallMethod(this, args);*/
            CallMethod("GetDepartmentNmae()");
            return DepartmentName;
        }
        public string EditDetails(int id)
        {
            Console.WriteLine("Update Your Id:");
            string updatedId= Console.ReadLine();
            return updatedId;
        }

        public string EditDetails()
        {
            Console.WriteLine("Update Your Id:");
            string updatedName = Console.ReadLine();
            return updatedName;
        }


        public string EditDetails(string Department)
        {
            Console.WriteLine("Update Your Id:");
            string updatedDepartment = Console.ReadLine();
            return updatedDepartment;
        }


    }
}
