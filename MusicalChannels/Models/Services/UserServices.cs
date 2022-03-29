using MusicalChannels.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalChannels.Models.Services
{
    public static class UserServices
    {
        public static bool Login(User user)
        {
            bool isTrue = false;
            using (DBContext context = new DBContext())
            {
                var found = context.Users.Where(x => x.Username == user.Username)
                     .Where(x => x.Password == user.Password).FirstOrDefault();

                isTrue = found == null ? false : true;
            }
            return isTrue;
        }

        public static (bool, string) Register(User user)
        {
            bool isTrue = false;
            string error = null;
            using (DBContext context = new DBContext())
            {
                var found = context.Users.Where(x => x.Username == user.Username).FirstOrDefault();
                var foundMail = context.Users.Where(x => x.Email == user.Email).FirstOrDefault();

                if (found == null && foundMail == null)
                {
                    context.Users.Add(new User
                    {
                        Username = user.Username,
                        Password = user.Password,
                        Email = user.Email,
                        IsAdmin = false
                    });

                    context.SaveChanges();
                    isTrue = true;
                }
                else
                {
                    error = found == null && foundMail != null ? "email is already registered" : "username is already registered";
                }
            }
            return (isTrue, error);
        }
        public static bool IsAdmin(User user)
        {
            bool isTrue = false;
            using (DBContext context = new DBContext())
            {
                var found = context.Users.FirstOrDefault(x => x.Username == user.Username);

                if (found.IsAdmin)
                {
                    isTrue = true;
                }
            }
            return isTrue;
        }
    }
}
