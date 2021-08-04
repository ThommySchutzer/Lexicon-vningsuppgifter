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
using WpfAppWithDapper.Services;
using WpfAppWithDapper.Models;

namespace WpfAppWithDapper
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

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            Services.Services.InsertCustomer(firstName.Text, lastName.Text, eMail.Text);
        }

        private void btnRoom_Click(object sender, RoutedEventArgs e)
        {
            Services.Services.InsertRoomType(type.Text, Convert.ToInt32(price.Text));
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Services.Services.MakeAnOrder(Convert.ToInt32(customerId.Text), Convert.ToInt32(productId.Text), Convert.ToInt32(numberOfDays.Text), Convert.ToInt32(total.Text));
        }

        private void btnGetEmail_Click(object sender, RoutedEventArgs e)
        {
            listBox3.Text += Services.Services.SelectCustomerEmail(Convert.ToInt32(emailForId.Text));
        }

        private void btnGetCustomers_Click(object sender, RoutedEventArgs e)
        {
            List<Customer> customerList;
            customerList = Services.Services.SelectCustomers();
            foreach (var item in customerList)
            {
                listBox4.Text += item.FirstName + "\n";
                listBox4.Text += item.LastName + "\n";
                listBox4.Text += item.Email + "\n";
            }
        }
    }
}
