using System.Collections.Generic;
using Exemple.Model;

namespace Exemple.DataAccess
{
    class EmployeeRepository
    {
        readonly List<Employee> _Employees;
        public EmployeeRepository()
        {
            if (_Employees == null)
            {
                _Employees=new List<Employee>();
            }
            _Employees.Add(Employee.CreatEpmloyee("arfaoui", "ikram"));
            _Employees.Add(Employee.CreatEpmloyee("mesrati", "charfeddine"));
            _Employees.Add(Employee.CreatEpmloyee("dadi", "sana"));
            _Employees.Add(Employee.CreatEpmloyee("ghraba", "ghofrane"));
        }
        public List<Employee> GetEmployees()
        {
            return new List<Employee>(_Employees);
        }

    }
}
