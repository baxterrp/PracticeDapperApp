using PracticeDapperApp.Data;
using System.Threading.Tasks;

namespace PracticeDapperApp.Services
{
    public interface IUserRepository
    {
        Task CreateUser(UserDataEntity userDataEntity);
        Task<UserDataEntity> FindUserById(string id);
    }
}
