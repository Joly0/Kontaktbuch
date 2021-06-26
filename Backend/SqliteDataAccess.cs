using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Backend
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (person.Id != -1)
                {
                    cnn.Execute("insert or replace into Person (Id, VorName, NachName, LieblingsLehrer, LieblingsDino) values (@Id, @VorName, @NachName, @LieblingsLehrer, @LieblingsDino)", person);
                }
                else
                {
                    cnn.Execute("insert or replace into Person (VorName, NachName, LieblingsLehrer, LieblingsDino) values (@VorName, @NachName, @LieblingsLehrer, @LieblingsDino)", person);
                }
            }
        }

        public static void DeletePerson(PersonModel person)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Person WHERE Id=@Id", person);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
