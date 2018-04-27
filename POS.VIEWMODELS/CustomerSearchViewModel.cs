using POS.BL;
using POS.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.VIEWMODELS
{
    public class CustomerSearchViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Customer> customers;

        public CustomerSearchViewModel()
        {
            customers = new ObservableCollection<Customer>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SearchCustomers(Dictionary<string, string> parameters)
        {
            Customers = new ObservableCollection<Customer>(CustomerRepository.GetCustomers(parameters).ToList());
        }

        public ObservableCollection<Customer> Customers
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
