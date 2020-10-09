using System.Collections.Generic;
using System.Linq;

namespace Post.Data{
    public class UserService{
        public List<User> GetAllUsers => UserData.getUsers.ToList();
        public User GetUserById(int UserId) => UserData.getUsers.FirstOrDefault(n=>n.Id == UserId);
    }
}