using DPLRef.eCommerce.Common.Shared;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DPLRef.eCommerce.Contracts.WebStore.Catalog
{
    [DataContract]
    public class WebStoreSearchResponse : ResponseBase
    {
        [DataMember]
        public ProductSearchItem[] Products { get; set; }
    }
}
