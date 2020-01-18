using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zza.Data;
using ZzaDashboard.Services;

namespace ZzaDashboard.ViewModel
{
    public class CustomerEditViewModel
    {
        public Customer Customer { get; set; }

        public ICustomersRepository CustomersRepository { get; set; }

        public ICommand SaveCommand { get; set; }

        public CustomerEditViewModel()
        {
            this.CustomersRepository = new CustomersRepository();
            this.Customer = this.CustomersRepository.GetCustomerAsync(new Guid("11DA4696-CEA3-4A6D-8E83-013F1C479618")).Result;
            this.SaveCommand = new RelayCommand(this.SaveCommandExecute, this.SaveCommandCanExecute);
        }

        public bool SaveCommandCanExecute(object obj)
        {
            if (string.IsNullOrWhiteSpace(this.Customer.FirstName) || string.IsNullOrWhiteSpace(this.Customer.LastName) || string.IsNullOrWhiteSpace(this.Customer.Phone))
            {
                return false;
            }
            return true;
        }

        public void SaveCommandExecute(object obj)
        {

        }
    }
}
