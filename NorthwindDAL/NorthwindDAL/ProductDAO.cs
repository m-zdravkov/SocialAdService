using NorthwindBDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL
{
    public class ProductDAO
    {

        public ProductBDO GetProduct(int id)
        {
            ProductBDO productBDO = null;
            using (var NWEntities = new NorthwindEntities1())
            {
                var product = (from p in NWEntities.Products
                               where p.ProductID == id
                               select p).FirstOrDefault();
                if (product != null)
                    productBDO = new ProductBDO()
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        QuantityPerUnit = product.QuantityPerUnit,
                        UnitPrice = (decimal)product.UnitPrice,
                        UnitsInStock = (int)product.UnitsInStock,
                        ReorderLevel = (int)product.ReorderLevel,
                        UnitsOnOrder = (int)product.UnitsOnOrder,
                        Discontinued = product.Discontinued,
                        RowVersion = product.Rowversion
                    };
            }
            return productBDO;
        }

        public bool UpdateProduct(
            ref ProductBDO productBDO,
            ref string message)
        {
            message = "product updated successfully";
            var ret = true;

            using (var NWEntities = new NorthwindEntities1())
            {
                var productID = productBDO.ProductID;
                var productInDB =
                        (from p
                        in NWEntities.Products
                         where p.ProductID == productID
                         select p).FirstOrDefault();
                // check product
                if (productInDB == null)
                {
                    throw new Exception("No product with ID " +
                                        productBDO.ProductID);
                }

                // update product
                productInDB.ProductName = productBDO.ProductName;
                productInDB.QuantityPerUnit = productBDO.QuantityPerUnit;
                productInDB.UnitPrice = productBDO.UnitPrice;
                productInDB.Discontinued = productBDO.Discontinued;
                productInDB.Rowversion = productBDO.RowVersion;

                NWEntities.Products.Attach(productInDB);
                NWEntities.Entry(productInDB).State = System.Data.Entity.EntityState.Modified;
                var num = NWEntities.SaveChanges();

                productBDO.RowVersion = productInDB.Rowversion;

                if (num != 1)
                {
                    ret = false;
                    message = "no product is updated";
                }
            }
            return ret;
        }

    }
}
