using System;
using Exemple.Model;
using Exemple.DataAccess;
using System.Collections.ObjectModel;


namespace Exemple.ViewModel
{
    class EmployeeListViewModel :ViewModelBase
    {
        readonly EmployeeRepository _EmployeeRepository;
        public ObservableCollection<Employee> AllEmployee
        {
            get;
            private set;
        }
        public EmployeeListViewModel(EmployeeRepository employeeRepository)
        {
            if (employeeRepository == null)
            {
                throw new ArgumentNullException("employeeRepository");
            }
            _EmployeeRepository = employeeRepository;
            this.AllEmployee = new ObservableCollection<Employee>(_EmployeeRepository.GetEmployees());

        }
        protected override void onDispose()
        {
            this.AllEmployee.Clear();
        }

    }
}
