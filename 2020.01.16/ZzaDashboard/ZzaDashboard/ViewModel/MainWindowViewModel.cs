using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zza.Data;
using ZzaDashboard.Services;

namespace ZzaDashboard.ViewModel
{
    class MainWindowViewModel
    {
        public ICustomersRepository CustomersRepository { get; set; }

        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer { get; set; }

        public MainWindowViewModel()
        {
            this.CustomersRepository = new CustomersRepository();
            this.Customers = new ObservableCollection<Customer>(this.CustomersRepository.GetCustomersAsync().Result);
        }
    }
}
