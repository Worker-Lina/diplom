using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public class EmployeeDataAccess : DbDataAccess<Employee>
    {
        public void Insert(Employee employee)
        {
            string insertSqlScript = "insert into Employees values (@ID, @FIO, @Position, @Salary, @Phone, @Login, @Password, @Address,@DateOfEmployment,@PhotoURL)";

            using (var transaction = connection.BeginTransaction())
            {
                using (var command = new SqlCommand(insertSqlScript, connection))
                {
                    try
                    {
                        command.Transaction = transaction;

                        var IDParameter = command.CreateParameter();
                        IDParameter.DbType = System.Data.DbType.Guid;
                        IDParameter.Value = employee.Id;
                        IDParameter.ParameterName = "ID";

                        command.Parameters.Add(IDParameter);


                        var FIOParameter = command.CreateParameter();
                        FIOParameter.DbType = System.Data.DbType.String;
                        FIOParameter.Value = employee.FIO;
                        FIOParameter.ParameterName = "FIO";

                        command.Parameters.Add(FIOParameter);

                        var PositionParameter = command.CreateParameter();
                        PositionParameter.DbType = System.Data.DbType.String;
                        PositionParameter.Value = employee.Position;
                        PositionParameter.ParameterName = "Position";

                        command.Parameters.Add(PositionParameter);

                        var SalaryParameter = command.CreateParameter();
                        SalaryParameter.DbType = System.Data.DbType.Decimal;
                        SalaryParameter.Value = employee.Salary;
                        SalaryParameter.ParameterName = "Salary";

                        command.Parameters.Add(SalaryParameter);


                        var PhoneParameter = command.CreateParameter();
                        PhoneParameter.DbType = System.Data.DbType.String;
                        PhoneParameter.Value = employee.Phone;
                        PhoneParameter.ParameterName = "Phone";

                        command.Parameters.Add(PhoneParameter);


                        var LoginParameter = command.CreateParameter();
                        LoginParameter.DbType = System.Data.DbType.String;
                        LoginParameter.Value = employee.Login;
                        LoginParameter.ParameterName = "Login";

                        command.Parameters.Add(LoginParameter);

                        var PasswordParameter = command.CreateParameter();
                        PasswordParameter.DbType = System.Data.DbType.String;
                        PasswordParameter.Value = employee.Password;
                        PasswordParameter.ParameterName = "Password";

                        command.Parameters.Add(PasswordParameter);


                        var AddressParameter = command.CreateParameter();
                        AddressParameter.DbType = System.Data.DbType.String;
                        AddressParameter.Value = employee.Address;
                        AddressParameter.ParameterName = "Address";

                        command.Parameters.Add(AddressParameter);

                        var DateParameter = command.CreateParameter();
                        DateParameter.DbType = System.Data.DbType.DateTime;
                        DateParameter.Value = employee.DateOfEmployment;
                        DateParameter.ParameterName = "DateOfEmployment";

                        command.Parameters.Add(DateParameter);


                        var PhotoURLParameter = command.CreateParameter();
                        PhotoURLParameter.DbType = System.Data.DbType.String;
                        PhotoURLParameter.Value = employee.PhotoURL;
                        PhotoURLParameter.ParameterName = "PhotoURL";

                        command.Parameters.Add(PhotoURLParameter);

                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (DbException)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public ICollection<Employee> Select()
        {
            var selectSqlScript = $"SELECT e.id, e.FIO, e.Position, e.Salary, e.Phone FROM Employees e";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var employees = new List<Employee>();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        employees.Add(new Employee
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            FIO = dataReader["FIO"].ToString(),
                            Position = dataReader["Position"].ToString(),
                            Salary = decimal.Parse(dataReader["Salary"].ToString()),
                            Phone = dataReader["Phone"].ToString()
                        });
                    }
                }
                return employees;
            }
        }


        public void Delete(Guid id)
        {
            var deleteSqlScript = $"Delete FROM Employees where id = '{id}'";

            using (var command = new SqlCommand(deleteSqlScript, connection))
            {
                command.ExecuteNonQuery();
            }
        }


        public Employee SelectEmployee(Guid id)
        {
            var selectSqlScript = $"SELECT * FROM Employees e where id = '{id}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var employee = new Employee();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        employee = new Employee
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            FIO = dataReader["FIO"].ToString(),
                            Position = dataReader["Position"].ToString(),
                            Salary = decimal.Parse(dataReader["Salary"].ToString()),
                            Phone = dataReader["Phone"].ToString(),
                            Login = dataReader["Login"].ToString(),
                            Password = dataReader["Password"].ToString(),
                            Address = dataReader["Address"].ToString(),
                            DateOfEmployment = DateTime.Parse(dataReader["DateOfEmployment"].ToString()),
                            PhotoURL = dataReader["PhotoURL"].ToString(),
                        };
                    }
                }
                return employee;
            }
        }


        public bool IsIdExist(Guid id)
        {
            var selectSqlScript = "select id from employees";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (id == Guid.Parse(dataReader["Id"].ToString()))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }




        public Employee SelectByLogin(string login)
        {
            var selectSqlScript = $"SELECT id, Login, Password, Position FROM Employees where login ='{login}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var employee = new Employee();

                using (var dataReader = command.ExecuteReader())
                {

                    while (dataReader.Read())
                    {
                        employee = new Employee
                        {
                            Id = Guid.Parse(dataReader["Id"].ToString()),
                            Login = dataReader["Login"].ToString(),
                            Password = dataReader["Password"].ToString(),
                            Position = dataReader["Position"].ToString()
                        };
                    }
                }
                return employee;
            }
        }


        public bool IsLoginExist(string login)
        {
            var selectSqlScript = "select login from Employees";

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

    }
}
