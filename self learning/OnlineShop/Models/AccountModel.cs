using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;

namespace Models
{
    public class AccountModel
    {
        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login(string UserName, string Password)
        {
            object[] sqlPrams =
            {
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password)
            };
            var res = context.Database.SqlQuery<bool>("Sp_Acccount_Login @UserName, @Password", sqlPrams).SingleOrDefault();
            return res;
        }
    }
}
