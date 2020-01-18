using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zza.Data;
using ZzaDashboard.Services;
using View_ViewModel.Commands;

namespace View_ViewModel.ViewModel
{
    class MainWindowViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindowViewModel()
        {
            this.Employees = new ObservableCollection<Employee>();
        }

        public bool GetCommandCanExecute(object obj)
        {
            return true;
        }
    }
}
