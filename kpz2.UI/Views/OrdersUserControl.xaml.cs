using kpz2.Models;
using kpz2.UI.ViewModels;
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

namespace kpz2.UI.Views
{
    /// <summary>
    /// Interaction logic for OrdersUserControl.xaml
    /// </summary>
    public partial class OrdersUserControl : UserControl
    {
        public OrdersUserControl()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {

            var order = (OrderViewModel)dataGrid1.SelectedItem;
            order.Status = OrderStatus.New;
        }

        private void buttonInProgress_Click(object sender, RoutedEventArgs e)
        {
            var order = (OrderViewModel)dataGrid1.SelectedItem;
            order.Status = OrderStatus.InProgress;
        }

        private void buttonInDelivery_Click(object sender, RoutedEventArgs e)
        {
            var order = (OrderViewModel)dataGrid1.SelectedItem;
            order.Status = OrderStatus.InDelivery;
        }

        private void buttonDelivered_Click(object sender, RoutedEventArgs e)
        {
            var order = (OrderViewModel)dataGrid1.SelectedItem;
            order.Status = OrderStatus.Delivered;
        }
    }
}
