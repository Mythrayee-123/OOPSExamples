using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IEmployee
    {
        void GetAllEmployeesFromDB();
        void InsertEmployee();
        void UpdateEmployee();
        void DeleteEmployee();

    }

    interface IDept
    {
        void GetAllDept();
        void UpdateDept();
        void DeleteDept();
    }
    internal class Program : IEmployee, IDept  //Multiple Inheritence
    {
        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public void GetAllEmployeesFromDB()
        {
            throw new NotImplementedException();
        }

        public void InsertEmployee()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee()
        {
            throw new NotImplementedException();
        }
        public void GetAllDept()
        {
            //logic
        }

        public void UpdateDept()
        {
            throw new NotImplementedException();
        }

        public void DeleteDept()
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.GetAllEmployeesFromDB();
            Console.ReadLine();
        }


    }
}
