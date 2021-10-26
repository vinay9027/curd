using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC.Models
{
    public class EmployeeService : IEmployee
    {
        private ApplicationContext Context { get; }

        public EmployeeService(ApplicationContext context)
        {
            Context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            Context.Employees.Add(employee);
            Context.SaveChanges();
            return employee;
        }


        public List<Employee> GetEmployees()
        {
            return Context.Employees.ToList();
        }

        public List<Departments> GetDepartments()
        {
            var depts = Context.departments.ToList();
            return depts;
        }
    }
}
