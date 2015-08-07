using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationModel;

namespace WebApplicationServices
{
    public class UserManager:TestBaseManager
    {
        public IList<User> GetAll()
        {
            using (var db = ReadTextContext)
            {
                return db.Users.ToList();
            }
        }
        public IList<User> GetUsers(int groupId)
        {
            using (var db = ReadTextContext)
            {
                return db.Users.Where(x => x.groupid == groupId).ToList();
            }

        }
        public bool AddUser(User user)
        {
            using (var db = WriteTextContext)
            {
                db.Users.Add(user);
                return db.SaveChanges()>0;
            }
        }
        public bool DeleteUser(int userId)
        {
            using (var db = WriteTextContext)
            {
                var user = db.Users.SingleOrDefault(x => x.id == userId);
                if (user != null)
                {
                    db.Users.Remove(user);
                    
                }
                return db.SaveChanges() > 0;
            }
        }
    }
}
