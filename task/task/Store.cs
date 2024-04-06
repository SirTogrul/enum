using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Store
    {
        Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }
        public void RemoveProductByNo(int no)
        {
            Product[] newProducts = new Product[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No != no)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = Products[i];
                    
                }
            }
            
            Products = newProducts;
        }
        public Product[] FilterProductByName(string name)
        {
            Product[] filterProduct = new Product[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref filterProduct, filterProduct.Length + 1);
                    filterProduct[filterProduct.Length - 1] =Products[i];
                }
            }
            return filterProduct;
        }
        public Product[] FilterProductByType(Core.Type type)
        {
            Product[] filterType = new Product[0];
            for(int i = 0;i < Products.Length;i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref filterType, filterType.Length + 1);
                    filterType[filterType.Length - 1] = Products[i];
                }
            }
            return filterType;
        }
    }
}
