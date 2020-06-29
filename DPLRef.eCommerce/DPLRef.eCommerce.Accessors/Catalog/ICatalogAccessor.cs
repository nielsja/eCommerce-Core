using DPLRef.eCommerce.Common.Shared;
using DPLRef.eCommerce.Accessors.DataTransferObjects;
using J2N.Collections.Generic;

// Cencept : Accessor
// Sub System : Catalog
namespace DPLRef.eCommerce.Accessors.Catalog
{
    public interface ICatalogAccessor : IServiceContractBase
    {
        WebStoreCatalog Find(int catalogId);

        WebStoreCatalog SaveCatalog(WebStoreCatalog catalog);

        void DeleteCatalog(int id);

        WebStoreCatalog[] FindAllSellerCatalogs();

        Product[] FindAllProductsForCatalog(int catalogId);

        Product FindProduct(int id);

        Product SaveProduct(int catalogId, Product product);

        void DeleteProduct(int catalogId, int id);

        #region Lab 21 - Linq code
        Product[] AllProductsInRange(decimal low, decimal high);

        Product[] AllProductsFromSupplier(string supplierName);

        ProductsBySupplierItem[] ProductsBySupplier();

        void UpdatePrice(int id, decimal price);
        #endregion
    }

    public class ProductsBySupplierItem
    {
        public string Supplier { get; set; }
        public int Count { get; set; }
    }
}
