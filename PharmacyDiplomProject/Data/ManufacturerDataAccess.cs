using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public class ManufacturerDataAccess : DbDataAccess<Manufacturer>
    {
        public void Insert(Manufacturer manufacturer)
        {
            string insertSqlScript = $"insert into Manufacturer values ('{manufacturer.Id}','{manufacturer.Name}', '{manufacturer.Country}', '{manufacturer.City}', '{manufacturer.Address}', '{manufacturer.Phone}')";

            using (var command = new SqlCommand(insertSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public ICollection<Manufacturer> Select()
        {
            var selectSqlScript = $"SELECT * FROM Manufacturer m";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var manufacturers = new List<Manufacturer>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        manufacturers.Add(new Manufacturer
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            Name = dataReader["Name"].ToString(),
                            Country = dataReader["Country"].ToString(),
                            City = dataReader["City"].ToString(),
                            Address = dataReader["Address"].ToString(),
                            Phone = dataReader["Phone"].ToString()
                        });
                    }
                }
                return manufacturers;
            }
        }

        public void Delete(Guid id)
        {
            var deleteSqlScript = $"Delete FROM Manufacturer where id = '{id}'";

            using (var command = new SqlCommand(deleteSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
