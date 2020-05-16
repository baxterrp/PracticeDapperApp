using PracticeDapperApp.Data;
using PracticeDapperApp.Models;
using System;
using System.Threading.Tasks;

namespace PracticeDapperApp.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        IDataMapper<UserModel, UserDataEntity> _userMapper;

        public UserService(IUserRepository userRepository, IDataMapper<UserModel, UserDataEntity> userMapper)
        {
            _userRepository = userRepository;
            _userMapper = userMapper;
        }

        public async Task<UserModel> CreateUser(UserModel userModel)
        {
            userModel.Id = Guid.NewGuid().ToString();
            var userDataEntity = _userMapper.MapTo(userModel);

            await _userRepository.CreateUser(userDataEntity);

            return userModel;
        }

        public async Task<UserModel> FindUser(string id)
        {
            var userDataEntity = await _userRepository.FindUserById(id);
            return _userMapper.MapFrom(userDataEntity);
        }
    }
}
