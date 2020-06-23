using DPLRef.eCommerce.Accessors.DataTransferObjects;
using DPLRef.eCommerce.Common.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPLRef.eCommerce.Accessors.Catalog
{
    public interface ISearchAccessor : IServiceContractBase
    {
        void RebuildIndex(int catalogId);
        Product[] Search(int catalogId, string text);
    }
}
