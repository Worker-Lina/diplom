using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public class UserDataAccess : DbDataAccess<User>
    {

        public bool IsLoginExist(string login)
        {
            var selectSqlScript = "select login from employees";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (login == dataReader["login"].ToString())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public User SelectUserByLogin(string login)
        {
            var selectSqlScript = $"SELECT u.Id, u.[login], u.[Password] FROM  employees u WHERE Login = '{login}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                using (var dataReader = command.ExecuteReader())
                {
                    var user = new User();

                    while (dataReader.Read())
                    {
                        user = new User
                        {
                            Id = int.Parse(dataReader["id"].ToString()),
                            Login = dataReader["login"].ToString(),
                            Password = dataReader["password"].ToString()
                        };
                    }
                    return user;
                }
            }
        }
    }
}
