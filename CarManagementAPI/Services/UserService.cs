using CarManagementAPI.Models;

namespace CarManagementAPI.Services
{
    public class UserService
    {
        private List<User> _users = new();

        public User Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(x => x.Username == username && x.Password == password);
        }

        public void Register(User user)
        {
            _users.Add(user);
        }
    }
}
