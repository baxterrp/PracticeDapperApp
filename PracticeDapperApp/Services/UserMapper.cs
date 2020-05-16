using PracticeDapperApp.Data;
using PracticeDapperApp.Models;
using PracticeDapperApp.POCOs;

namespace PracticeDapperApp.Services
{
    public class UserMapper : IDataMapper<UserModel, UserDataEntity>
    {
        public UserModel MapFrom(UserDataEntity dataEntity)
        {
            return new UserModel
            {
                Id = dataEntity.Id,
                Email = dataEntity.Email,
                Name = new Name
                {
                    First = dataEntity.FirstName,
                    Last = dataEntity.LastName
                },
                Address = new Address
                {
                    Street = dataEntity.Address,
                    City = dataEntity.City,
                    State = dataEntity.State,
                    ZipCode = dataEntity.Zip
                }
            };
        }

        public UserDataEntity MapTo(UserModel model)
        {
            return new UserDataEntity
            {
                Id = model.Id,
                Email = model.Email,
                Address = model.Address.Street,
                City = model.Address.City,
                State = model.Address.State,
                Zip = model.Address.ZipCode,
                FirstName = model.Name.First,
                LastName = model.Name.Last
            };
        }
    }
}
