using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public abstract class DbDataAccess<T> : IDisposable
    {
        protected readonly SqlConnection connection;

        public DbDataAccess()
        {
            connection = new SqlConnection();
            connection.ConnectionString = "Server=DESKTOP-S7AP05F; Database=Pharmacy; Trusted_Connection=True;";
            connection.Open();
        }

        public void Dispose()
        {
            connection.Close();
        }

    }
}
