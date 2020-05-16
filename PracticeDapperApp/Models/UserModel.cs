using PracticeDapperApp.POCOs;

namespace PracticeDapperApp.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
    }
}
