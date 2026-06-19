using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ContractMonthlyClaimSystemsPrototype.Models; 
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ContractMonthlyClaimSystemsPrototype
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // 1. Initialize the Database logic (Creates DB if it doesn't exist)
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());

            // 2. Call the function to create Roles and a Default Coordinator user
            CreateRolesAndUsers();
        }

        // === AUTOMATION LOGIC: Auto-Create Roles & Default User ===
        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Create "Lecturer" Role
            if (!roleManager.RoleExists("Lecturer"))
            {
                var role = new IdentityRole();
                role.Name = "Lecturer";
                roleManager.Create(role);
            }

            // Create "Coordinator" Role
            if (!roleManager.RoleExists("Coordinator"))
            {
                var role = new IdentityRole();
                role.Name = "Coordinator";
                roleManager.Create(role);
            }

            // Create "HR" Role (Required for your Invoice View)
            if (!roleManager.RoleExists("HR"))
            {
                var role = new IdentityRole();
                role.Name = "HR";
                roleManager.Create(role);
            }

            // === Create a Default Coordinator User for Testing ===
            // This helps your assessor log in immediately to test the 'Approval' view.
            var coordEmail = "coordinator@cmcs.com";
            var testUser = userManager.FindByEmail(coordEmail);

            if (testUser == null)
            {
                var administrator = new ApplicationUser();
                administrator.UserName = coordEmail;
                administrator.Email = coordEmail;

                // Create user with password "Password123!"
                var check = userManager.Create(administrator, "Password123!");

                if (check.Succeeded)
                {
                    // Assign the user to the Coordinator role
                    userManager.AddToRole(administrator.Id, "Coordinator");
                }
            }
        }
    }
}