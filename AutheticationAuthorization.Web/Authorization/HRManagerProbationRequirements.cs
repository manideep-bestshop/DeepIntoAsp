﻿using Microsoft.AspNetCore.Authorization;

namespace AuthenticationAuthorization.Web.Authorization
{
    public class HRManagerProbationRequirements:IAuthorizationRequirement
    {
        public HRManagerProbationRequirements(int probationMonths)
        {
            ProbationMonths = probationMonths;
        }
        public int ProbationMonths { get; }
    }
    public class HRManagerProbationRequirementsHandler:AuthorizationHandler<HRManagerProbationRequirements>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HRManagerProbationRequirements requirement)
        {
          if(!context.User.HasClaim(x=>x.Type=="EmploymentDate"))
                return Task.CompletedTask;

            var empDate = DateTime.Parse(context.User.FindFirst(x=>x.Type=="EmploymentDate").Value);
            var period = DateTime.Now - empDate;
            if (period.Days > 30 * requirement.ProbationMonths)
                context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
