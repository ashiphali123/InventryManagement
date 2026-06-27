using Inventory.Models;
//using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
    public class RoleInventory : IRoleInventory
    {
        private RoleManager<Microsoft.AspNetCore.Identity.IdentityRole> _roleManager;
        private UserManager<AppUser> _userManager;
        public RoleInventory(RoleManager<Microsoft.AspNetCore.Identity.IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task AddRoleAsync(string AppUserId)
        {
            var user = await _userManager.FindByIdAsync(AppUserId);
            var roles = _roleManager.Roles;
            List<string> StringRoles = new List<string>();
            if(user != null)
            {
                foreach(var item in roles)
                {
                    StringRoles.Add(item.Name);
                }
                await _userManager.AddToRolesAsync(user, StringRoles);
            }
        }

        public Task CreateNewRoleAsync()
        {
            /*Type t = typeof(TopMenu);
            foreach(Type classObj  in t.GetNestedTypes())
            {
                foreach(var objField in classObj.GetField())
                {
                    if(objField.Name.Constains)
                    {

                    }
                }
            }*/
            return Task.CompletedTask;
        }
    }
}
