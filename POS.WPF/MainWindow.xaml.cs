﻿using POS.BL;
using POS.EF;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static POS.BL.Payment;

namespace POS.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new POSContext())
            {
                //Payment p = new Payment(10, PaymentType.Cash);
                // db.Payments.Add(p);
                //db.SaveChanges();
                //int id = p.Id;

                var q = from p in db.Payments
                        select p;

                listPayments.ItemsSource = q.ToList();
            }
        }
    }
}
