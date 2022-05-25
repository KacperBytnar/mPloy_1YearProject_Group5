using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace mPloy_FinalProject_group5.Common
{
    public static class UserExtensions
    {
        public static int GetUserId(this ClaimsPrincipal user)
        {
            return Int32.Parse(user.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
    }
}
