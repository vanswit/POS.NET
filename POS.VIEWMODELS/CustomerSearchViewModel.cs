using POS.BL;
using POS.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.VIEWMODELS
{
    public class CustomerSearchViewModel : INotifyPropertyChanged
    {
        private IEnumerable<Customer> customers;

        public CustomerSearchViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SearchCustomers(Dictionary<string, string> parameters)
        {
            Customers = CustomerRepository.GetCustomers(parameters);
        }

        public IEnumerable<Customer> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                NotifyPropertyChanged("Customers");
            }
        }

    }
}
