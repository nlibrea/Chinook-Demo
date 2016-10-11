using Chinook.Framework.DAL.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Chinook.Framework.BLL.Security
{
    public class RoleManager : RoleManager<IdentityRole>
    {
        public RoleManager()
            : base(new RoleStore<IdentityRole>(new ApplicationDbContext()))
        {

        }
    }
}
