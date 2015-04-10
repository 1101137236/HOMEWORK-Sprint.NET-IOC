using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KuasCore.Models;

namespace KuasCore.Dao.Impl
{
    class NewEmployeeDao : IEmployeeDao
    {



        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employee = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "mouse";
            employee1.Name = "皮卡丘";
            employee1.Age = 1;
            employee.Add(employee1);

            Employee employee2 = new Employee();
            employee2.Id = "bird";
            employee2.Name = "火焰鳥";
            employee2.Age = 2;
            employee.Add(employee2);

            return employee;
        }

        public Employee GetEmployeeById(string id)
        {

            Employee employee = null;
            
            if ("mouse".Equals(id))
            {
                employee = new Employee();
                employee.Id = "mouse";
                employee.Name = "皮卡丘";
                employee.Age = 1;
            }

            return employee;
        }

    }
}
