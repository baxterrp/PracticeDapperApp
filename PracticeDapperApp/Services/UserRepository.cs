using Dapper;
using PracticeDapperApp.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PracticeDapperApp.Services
{
    public class UserRepository : IUserRepository
    {
        private string _connectionString = "Data Source = Silver; Initial Catalog = PracticeCommerce; Integrated Security = True;";

        private string _findUser = "SELECT * FROM Users WHERE [Id] = @Id";
        private string _insertUser = 
            @"INSERT INTO Users (id, firstName, lastName, email, address, city, state, zip) VALUES " + 
            "(@Id, @FirstName, @LastName, @Email, @Address, @City, @State, @Zip)";

        public async Task CreateUser(UserDataEntity userDataEntity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(_insertUser, userDataEntity);
            }
        }

        public async Task<UserDataEntity> FindUserById(string id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QuerySingleAsync<UserDataEntity>(_findUser, new { Id = id });
            }
        }
    }
}
