using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace kpz2.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string? Name { get; set; }
        [DataMember]
        public string? Description { get; set; }
        [DataMember]
        public float Price { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}
