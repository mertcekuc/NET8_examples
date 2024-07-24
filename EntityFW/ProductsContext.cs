using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EntityFW
{
    public class ProductsContext :DbContext
    {
        public  DbSet<Product> Products { get; set; }


        public ProductsContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

    }

    
}
