using Microsoft.AspNetCore.Identity;
using SistemaDeConvocacoes.Domain.Models;
using SistemaDeConvocacoes.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Presentation.Helpers
{
    public class SeedHelpers
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public SeedHelpers(RoleManager<IdentityRole> roleManager, 
            UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task Seed()
        {
            if (!await _roleManager.RoleExistsAsync(RolesNames.ROLE_ADMIN))
               await _roleManager.CreateAsync(new IdentityRole(RolesNames.ROLE_ADMIN));

            if (!await _roleManager.RoleExistsAsync(RolesNames.ROLE_CLIENTE))
                await _roleManager.CreateAsync(new IdentityRole(RolesNames.ROLE_CLIENTE));

            if (!await _roleManager.RoleExistsAsync(RolesNames.ROLE_USUARIO))
                await _roleManager.CreateAsync(new IdentityRole(RolesNames.ROLE_USUARIO));

            if (!await _roleManager.RoleExistsAsync(RolesNames.ROLE_CONVOCADO))
                await _roleManager.CreateAsync(new IdentityRole(RolesNames.ROLE_CONVOCADO));

            const string email = "admin@admin.com.br";
            const string password = "Admin123!";

            var user = new ApplicationUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                var user2 = await _userManager.FindByNameAsync(email);
                await _userManager.AddToRoleAsync(user2, RolesNames.ROLE_ADMIN);
            }
        }
    }
}
