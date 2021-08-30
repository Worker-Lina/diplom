using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public class PurchaseDataAccess : DbDataAccess<Purchase>
    {
        public void InsertReceipt(Purchase purchase)
        {
            string insertSqlScript = $"insert into Receipt values ('{purchase.Id}','{purchase.DateTime}', {purchase.sum})";    
            
            using (var command = new SqlCommand(insertSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void InsertPurchase(Product product, Purchase purchase, int count)
        {
            string insertSqlScript = $"insert into Purchases values ('{product.Id}','{purchase.Id}', {count})";

            using (var command = new SqlCommand(insertSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }


        public List<Finance> SelectFinance()
        {
            var selectSqlScript = $"select ProductId, (select name from products where id=pu.ProductId ) as name,  sum([count]) as [count], (select SellingPrice from products where id = pu.ProductId ) as price,  (select SellingPrice from products where id = pu.ProductId )*sum([count]) as summa from Purchases pu where (select [DateTime] from Receipt r where pu.ReceiptId = r.id)>=GETDATE()-7 group by ProductId order by sum([count]) desc";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var finances = new List<Finance>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        finances.Add(new Finance
                        {
                            ProductId = Guid.Parse(dataReader["ProductId"].ToString()),
                            Name = dataReader["name"].ToString(),
                            Count = int.Parse(dataReader["count"].ToString()),
                            Price = decimal.Parse(dataReader["price"].ToString()),
                            Summa = decimal.Parse(dataReader["summa"].ToString())
                        });
                    }
                }
                return finances;
            }
        }

        public List<Finance> SelectFinanceAll()
        {
            var selectSqlScript = $"select ProductId, (select name from products where id=pu.ProductId ) as name,  sum([count]) as [count], (select SellingPrice from products where id = pu.ProductId ) as price,  (select SellingPrice from products where id = pu.ProductId )*sum([count]) as summa from Purchases pu group by ProductId order by sum([count]) desc";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var finances = new List<Finance>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        finances.Add(new Finance
                        {
                            ProductId = Guid.Parse(dataReader["ProductId"].ToString()),
                            Name = dataReader["name"].ToString(),
                            Count = int.Parse(dataReader["count"].ToString()),
                            Price = decimal.Parse(dataReader["price"].ToString()),
                            Summa = decimal.Parse(dataReader["summa"].ToString())
                        });
                    }
                }
                return finances;
            }
        }

    }
}
