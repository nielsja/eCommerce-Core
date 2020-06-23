using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DPLRef.eCommerce.Contracts.WebStore.Catalog
{
    [DataContract]
    public class ProductSearchItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}
