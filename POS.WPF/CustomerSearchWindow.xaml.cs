using POS.VIEWMODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POS.WPF
{
    /// <summary>
    /// Interaction logic for CustomerSearchWindow.xaml
    /// </summary>
    public partial class CustomerSearchWindow : Window
    {
        CustomerSearchViewModel ViewModel;

        public CustomerSearchWindow()
        {
            ViewModel = new CustomerSearchViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {

            }

            if (!string.IsNullOrEmpty(txtLastName.Text))
            {

            }

            if (!string.IsNullOrEmpty(txtCity.Text))
            {

            }

            if (!string.IsNullOrEmpty(txtEmailAddress.Text))
            {

            }

            ViewModel.SearchCustomers(null);
        }
    }
}
