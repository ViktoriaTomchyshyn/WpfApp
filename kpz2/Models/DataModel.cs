using kpz2.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz2.Models
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Product>? Products { get; set; }
        [DataMember]
        public IEnumerable<Order>? Orders { get; set; }

        public DataModel()
        {
            Products = new List<Product>() { new Product() { Id = 1, Name = "T-shirt", Description = "Cool striped white t-shirt", Price = 550, Quantity = 120 }};
            Orders = new List<Order>() { new Order() { Id = 1, Status = OrderStatus.InProgress, Created = DateTime.Now, ProductId = 1, CustomerName = "Viktoriia Tomchyshyn", CustomerAddress = "some adress", CustomerNumber = "+380985678192" }};
        }

        public static string DataPath = "shop.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
