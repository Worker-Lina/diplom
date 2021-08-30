using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public class ProductDataAccess : DbDataAccess<Product>
    {
        public Product SelectProductById(Guid id)
        {
            var selectSqlScript = $"select d.id, d.Name, d.SellingPrice, d.PhotoURL, d.description, d.Сategory from Products d where id='{id}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var product = new Product();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        product = new Product
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            Name = dataReader["Name"].ToString(),
                            SellingPrice = decimal.Parse(dataReader["SellingPrice"].ToString()),
                            PhotoURL = dataReader["PhotoURL"].ToString(),
                            Description = dataReader["Description"].ToString(),
                            Category = dataReader["Сategory"].ToString()
                        };
                    }
                }
                return product;
            }
        }



        public List<Product> SelectProductByCategory(string category)
        {
            var selectSqlScript = $"select d.Name, d.SellingPrice, d.count from Products d where Сategory='{category}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var products = new List<Product>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        products.Add( new Product
                        {
                            Name = dataReader["Name"].ToString(),
                            SellingPrice = decimal.Parse(dataReader["SellingPrice"].ToString()),
                            Count = int.Parse(dataReader["Count"].ToString()),
                        });
                    }
                }
                return products;
            }
        }


        public Product SelectProductByName(string name)
        {
            var selectSqlScript = $"select d.Id, d.Name, d.SellingPrice, d.PhotoURL from Products d where name='{name}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var product = new Product();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        product = new Product
                        {
                            Name = dataReader["Name"].ToString(),
                            SellingPrice = decimal.Parse(dataReader["SellingPrice"].ToString()),
                            PhotoURL = dataReader["PhotoURL"].ToString()
                        };
                    }
                }
                return product;
            }
        }


        public ICollection<Product> SelectProductsByName(string name)
        {
            var selectSqlScript = $"select d.Id, d.Name, d.SellingPrice, d.Count from Products d where name='{name}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var products = new List<Product>();

                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            Name = dataReader["Name"].ToString(),
                            SellingPrice = decimal.Parse(dataReader["SellingPrice"].ToString()),       
                            Count = int.Parse(dataReader["Count"].ToString())
                        });
                    }
                }
                return products;
            }
        }

        public ICollection<Product> Select()
        {
            var selectSqlScript = $"SELECT p.id, p.Name, p.sellingPrice, p.Count FROM Products p";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var products = new List<Product>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            Name = dataReader["Name"].ToString(),
                            SellingPrice = decimal.Parse(dataReader["SellingPrice"].ToString()),
                            Count = int.Parse(dataReader["Count"].ToString())
                        });
                    }
                }
                return products;
            }
        }



        //TODO

        public ICollection<Product> SelectNew()
        {
            var selectSqlScript = $"select d.id, d.Name, d.PurchasePrice, d.count from Products d";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var products = new List<Product>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        products.Add(new Product
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            Name = dataReader["Name"].ToString(),
                            PurchasePrice = decimal.Parse(dataReader["PurchasePrice"].ToString()),
                            Count = int.Parse(dataReader["Count"].ToString())
                        });
                    }
                }
                return products;
            }
        }





        public void Insert(Product product)
        {
            string insertSqlScript = $"insert into Products values ('{product.Id}','{product.Name}', '{product.Category}', '{product.Manufacturer}', {product.PurchasePrice}, {product.SellingPrice}, '{product.Recipe}', '{product.ReleaseDate}', '{product.SellBeforeDate}', {product.Count}, '{product.PhotoURL}', '{product.Description}')";

            using (var command = new SqlCommand(insertSqlScript, connection))
            {
                     command.ExecuteNonQuery();
            }
        }


        public void Delete(Guid id)
        {
            var deleteSqlScript = $"Delete FROM Products where id = '{id}'";

            using (var command = new SqlCommand(deleteSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ChangeCount(Guid id, int amount)
        {
            var deleteSqlScript = $"Update products set Count = Count-{amount} where id ='{id}'";

            using (var command = new SqlCommand(deleteSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void ChangeCountPlus(Guid id, int amount)
        {
            var deleteSqlScript = $"Update products set Count = Count+{amount} where id ='{id}'";

            using (var command = new SqlCommand(deleteSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }




        public List<string> SelectManufacturer()
        {
            var selectSqlScript = $"select p.name from Manufacturers p";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                List<string> manufacturers = new List<string>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        string name = dataReader["Name"].ToString();
                        manufacturers.Add(name);
                    }
                }
                return manufacturers;
            }
        }


        public List<string> SelectCategories()
        {
            var selectSqlScript = $"select [group] from Prescription_of_drugs";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                List<string> categories = new List<string>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        string group = dataReader["group"].ToString();
                        categories.Add(group);
                    }
                }
                return categories;
            }
        }










        public List<Product> SelectNeedProduct()
        {
            var selectSqlScript = $"select p.name, p.purchasePrice, p.count from products p where count<5";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var products = new List<Product>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        products.Add(new Product
                        {
                            Name = dataReader["Name"].ToString(),
                            PurchasePrice = decimal.Parse(dataReader["purchasePrice"].ToString()),
                            Count = int.Parse(dataReader["Count"].ToString())
                        });
                    }
                }
                return products;
            }
        }

    }
}
