using PracticeDapperApp.Models;
using System.Threading.Tasks;

namespace PracticeDapperApp.Services
{
    public interface IUserService
    {
        Task<UserModel> CreateUser(UserModel userModel);
        Task<UserModel> FindUser(string id);
    }
}
