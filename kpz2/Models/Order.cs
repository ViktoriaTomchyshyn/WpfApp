using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz2.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public OrderStatus Status { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string? CustomerName { get; set; }
        [DataMember]
        public string? CustomerAddress { get; set; }
        [DataMember]
        public string? CustomerNumber { get; set; }
    }

    [DataContract]
    public enum OrderStatus
    {
        [EnumMember]
        New,

        [EnumMember]
        InProgress,

        [EnumMember]
        InDelivery,

        [EnumMember]
        Delivered
    }

}
