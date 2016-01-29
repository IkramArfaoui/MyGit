using System.Collections.ObjectModel;
using Exemple.DataAccess;

namespace Exemple.ViewModel
{
    class MainWindowsViewModel :ViewModelBase
    {
        readonly EmployeeRepository _EmployeeRepository;
        ObservableCollection<ViewModelBase> _ViewModels;
        public MainWindowsViewModel()
        {
            _EmployeeRepository = new EmployeeRepository();
            EmployeeListViewModel viewModel = new EmployeeListViewModel(_EmployeeRepository);
            this.ViewModels.Add(viewModel);

        }
        public ObservableCollection<ViewModelBase> ViewModels
        {
            get
            {
                if(_ViewModels== null)
                {
                    _ViewModels = new ObservableCollection<ViewModelBase>();
                   
                }
                return _ViewModels;
            }
        }
    }
}
