using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Repositories
{
    class UserRepository
    {
        private vgrEntities db = new vgrEntities();
        public bool UsernameExists(string Username)
        {
            return db.users.Any(x => x.username == Username);
        }
        public int GetId(string Username)
        {
            var username = db.users.SingleOrDefault(x => x.username == Username);
            if(username != null)
            {
                return (int)username.id;
            }
            return 0;
        }

        public string getPwd(string Username)
        {
            var username = db.users.SingleOrDefault(x => x.username == Username);
            if(username != null)
            {
                return username.password;
            }
            return null;
        }
    }
}
