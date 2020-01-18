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
        public ObservableCollection<Customer> Customers { get; set; }

        private ICustomersRepository CustomersRepository { get; set; }

        public ICommand GetCommand { get; set; }


        public MainWindowViewModel()
        {
            this.Customers = new ObservableCollection<Customer>();
            this.GetCommand = new RelayCommand(this.GetCommandExecute, this.GetCommandCanExecute);
            this.CustomersRepository = new CustomersRepository();
        }

        public bool GetCommandCanExecute(object obj)
        {
            return true;
        }

        public async void GetCommandExecute(object obj)
        {
            List<Customer> customers = await this.CustomersRepository.GetCustomersAsync();
            foreach (var customer in customers)
            {
                this.Customers.Add(customer);
            }
        }
    }
}
