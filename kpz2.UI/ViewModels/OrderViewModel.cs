using kpz2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz2.UI.ViewModels
{
    public class OrderViewModel:ViewModelBase
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
       
        private OrderStatus _status;
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        private DateTime _created;
        public DateTime Created
        {
            get
            {
                return _created;
            }
            set
            {
                _created = value;
                OnPropertyChanged("Created");
            }
        }

        private int _productId;
        
        public int ProductId
        {
            get{
                return _productId;
            }
            set
            {
                _productId = value;
                OnPropertyChanged("ProductId");
            }
        }
       
        private string _customerName;
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        private string _customerAdress;
        public string CustomerAddress
        {
            get
            {
                return _customerAdress;
            }
            set
            {
                _customerAdress = value;
                OnPropertyChanged("CustomerAdress");
            }
        }

        private string _customerNumber;
        public string CustomerNumber
        {
            get
            {
                return _customerNumber;
            }

            set
            {
                _customerNumber = value;
                OnPropertyChanged("CustomerNumber");
            }
        }
    }
}

