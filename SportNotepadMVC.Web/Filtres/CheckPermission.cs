using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Filtres
{
    public class CheckPermission : Attribute, IAuthorizationFilter
    {
        private readonly string _permission;
        public CheckPermission(string permission)
        {
            _permission = permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool isAuthoried = CheckUserPermission(context.HttpContext.User, _permission);

            if(!isAuthoried)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool CheckUserPermission(ClaimsPrincipal user, string permission)
        {
            return permission == "Read";
        }
    }
}
