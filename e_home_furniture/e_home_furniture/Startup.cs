using e_home_furniture.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(e_home_furniture.Startup))]
namespace e_home_furniture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //  CreateRolesandUsers();
        }


        // In this method we will create default User roles and Admin user for login
        /* private void CreateRolesandUsers()
        {
           ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            

            // In Startup iam creating first Admin Role and creating a default Admin User 
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin role
                var role = new IdentityRole
                {
                    Name = RoleName.Admin
                };
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website				

                var user = new ApplicationUser
                {                    
                    Email = "panonitweb@gmail.com",
                    UserName = "panonit",
                    FirstName = "Spasoje",
                    LastName = "Tomanic",
                    Address = "Lazara Nancica bb",
                    Role = "Admin"
                };

                string userPWD = "Web.123";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Manager role 
            /*if (!roleManager.RoleExists("Manager"))
			{
				var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
				role.Name = RoleName.Manager;
				roleManager.Create(role);

			}*/ /*
            else
            {
                var role = new IdentityRole
                {
                    Name = RoleName.User
                };
                roleManager.Create(role);
            }
        }*/
    }
}
