using kpz2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace kpz2.UI.ViewModels
{
    public class DataViewModel:ViewModelBase
    {
        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
           // NewOrderCommand = new Command(NewOrder);
           // InProgressOrderCommand = new Command(InProgressOrder);
           // InDeliveryOrderCommand = new Command(InDeliveryOrder);
           // DeliveredOrderCommand = new Command(DeliveredOrder);
        }

        private string _visibleControl = "Orders";

        public string VisibleControl
        {
             get { return _visibleControl; }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }
        private OrderViewModel _selectedOrder;

        public OrderViewModel SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }
        public ICommand NewOrderCommand { get; set; }

        public void NewOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.New;
        }

        public ICommand InProgressOrderCommand { get; set; }

        public void InProgressOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.InProgress;
        }

        public ICommand InDeliveryOrderCommand { get; set; }

        public void InDeliveryOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.InDelivery;
        }

        public ICommand DeliveredOrderCommand { get; set; }

        public void DeliveredOrder(object args)
        {
            SelectedOrder.Status = OrderStatus.Delivered;
        }
     
        public ICommand SetControlVisibility { get; set; }

        public void ControlVisibility(object args)
        {
            VisibleControl = args.ToString();
        }

        private ObservableCollection<ProductViewModel> _products;

        public ObservableCollection<ProductViewModel> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged("Products");
            }
        }

        private ObservableCollection<OrderViewModel> _orders;

        public ObservableCollection<OrderViewModel> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }

    }
}
