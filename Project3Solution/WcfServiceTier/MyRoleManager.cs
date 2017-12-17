using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.ServiceModel;

namespace WcfServiceTier
{
    [Obsolete("Not implemented yet!", true)]
    public class MyRoleManager : ServiceAuthorizationManager
    {
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
            //Get the current pipeline user context, used for user identifying
            var identity = operationContext.ServiceSecurityContext.PrimaryIdentity;

            //Simulate that we get a user and all his roles from the database
            //This would be refactored to use the control layer
            bool? userFound = true;
            string[] userRolesFound = new string[] { "Admin", "User" };

            if (userFound == null || userFound == false)
            {
                throw new Exception("User not found");
            }
            else
            {
                //Assign roles to the Principal property for runtime to match with PrincipalPermissionAttributes decorated on the service operation.
                var principal = new GenericPrincipal(operationContext.ServiceSecurityContext.PrimaryIdentity, userRolesFound);
                //assign principal to auth context with the users roles
                operationContext.ServiceSecurityContext.AuthorizationContext.Properties["Principal"] = principal;
                //return true if all goes well
                return true;
            }
        }
    }
}
