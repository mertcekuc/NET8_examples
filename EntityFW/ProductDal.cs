using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW
{
    public class ProductDal
    {

        string connectıonStrıng = @"server=(localdb)\mssqllocaldb;initial catalog=proje;integrated security=true";

        public List<Product> GetAll()
        {
            using (ProductsContext context = new ProductsContext(connectıonStrıng))
            {
                var result = context.Products.Where(p => p.id > 0 && p.ProductName.StartsWith("mert"));
                return context.Products.ToList();
                
            }
        }

        public void Add(Product p)
        {
            using (ProductsContext context = new ProductsContext(connectıonStrıng))
            {

                context.Products.Add(p);
                context.SaveChanges();
            }
        }

        public void Delete(Product p)
        {
            using (ProductsContext context = new ProductsContext(connectıonStrıng))
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public void Update(Product p)
        {
            using (ProductsContext context = new ProductsContext(connectıonStrıng))
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }


        }

        public List<Product> Search(String key)
        {
            using (ProductsContext context = new ProductsContext(connectıonStrıng))
            {
                var result = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
                return result;
            }
        }
      

    }
}
