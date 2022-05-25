using mPloy_FinalProject_group5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace mPloy_FinalProject_group5.Services.Interfaces
{
    public interface IUserService
    {
        public List<AppUser> GetAllUsers();
        //public void CreateUser(AppUser user);
        public AppUser GetUserById(int id);
        public Task<AppUser> EditUser(AppUser user);
    }
}
