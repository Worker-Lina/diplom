using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDiplomProject.Data
{
    public class RecipeDataAccess : DbDataAccess<Recipe>
    { 
        public Recipe Select(string iin)
        {
            var selectSqlScript = $"select r.recipePhoto from RecipePatient r where IIN='{iin}'";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                var recipe = new Recipe();

                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        recipe = new Recipe
                        {
                            Photo = dataReader["recipePhoto"].ToString()
                        };
                    }
                }
                return recipe;
            }
        }


        public bool IsIINExist(string IIN)
        {
            var selectSqlScript = "select IIN from RecipePatient";

            using (var command = new SqlCommand(selectSqlScript, connection))
            {
                using (var dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        if (IIN == dataReader["IIN"].ToString())
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
