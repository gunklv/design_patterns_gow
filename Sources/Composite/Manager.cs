using System.Collections.Generic;

namespace Composite
{
    public class Manager : Employee
    {
        private List<Employee> employeeList = new List<Employee>();

        public Manager(string name, string position) : base(name, position)
        {
        }

        public void addEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        public void removeEmployee(Employee employee)
        {
            employeeList.Remove(employee);
        }
    }
}
