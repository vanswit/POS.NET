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
            this.DataContext = ViewModel;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                parameters.Add("FirstName", txtFirstName.Text);
            }
            else parameters.Add("FirstName", null);

            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                parameters.Add("LastName", txtLastName.Text);
            }
            else parameters.Add("LastName", null);


            if (!string.IsNullOrEmpty(txtCity.Text))
            {
                parameters.Add("City", txtCity.Text);
            }
            else parameters.Add("City", null);


            if (!string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                parameters.Add("Email", txtEmailAddress.Text);
            }
            else parameters.Add("Email", null);


            

            ViewModel.SearchCustomers(parameters);
        }
    }
}
