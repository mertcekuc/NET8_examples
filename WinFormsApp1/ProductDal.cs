using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public class ProductDal
    {

        
         SqlConnection _connection = new SqlConnection
                (@"server=(localdb)\mssqllocaldb;initial catalog=proje;integrated security=true");

        public void connectionCopntrol()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
                _connection.Open();
        }
        
        public List<Product> GetAll()
        {
           

            SqlCommand command = new SqlCommand("select * from Products",_connection);
            connectionCopntrol();
           
            var reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();

            List<Product> products = new List<Product>();

            while (reader.Read()) { 
                Product product = new Product()
                {
                    id = Convert.ToInt32(reader["id"]),
                    ProductName = reader["ProductName"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])

                };
                products.Add(product);
            }
            _connection.Close();
            reader.Close();
            
            return products;


        }

        public void Add(Product product)
        {
            connectionCopntrol();
            SqlCommand command = new SqlCommand(
                "insert into Products Values(@name, @unitPrice, @stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.ProductName);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Update(Product product)
        {
            connectionCopntrol();
            SqlCommand command = new SqlCommand("UPDATE Products " +
                "SET ProductName=@name, UnitPrice=@price, StockAmount=@amount " +
                "WHERE id=@id",_connection);
            command.Parameters.AddWithValue("@id",product.id);
            command.Parameters.AddWithValue("@name", product.ProductName);
            command.Parameters.AddWithValue("@price", product.UnitPrice);
            command.Parameters.AddWithValue("@amount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Delete(int id)
        {
            connectionCopntrol();
            SqlCommand command = new SqlCommand("DELETE FROM Products WHERE id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
