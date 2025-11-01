using Microsoft.AspNetCore.Identity;
using System.Text.RegularExpressions;

namespace PetAdoptionPortal.Web.Security
{
    public class CustomPasswordValidator : IPasswordValidator<IdentityUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<IdentityUser> manager, IdentityUser user, string password)
        {
            var errors = new List<IdentityError>();

            if (password.Count(char.IsUpper) < 2)
                errors.Add(new IdentityError { Code = "UppercaseRequirement", Description = "Password must contain atleast 2 uppercase letters." });

            if (password.Count(char.IsDigit) < 3)
                errors.Add(new IdentityError { Code = "DigitRequirement", Description = "Password must contain at least 3 digits." });

            //symbols = non-letter nindigit punctutaion . count those

            int symbolCount = password.Count(c => !char.IsLetterOrDigit(c));
            if (symbolCount < 3)
                errors.Add(new IdentityError { Code = "SymbolRequirement", Description = "Password must contain at least 3 symbols." });

            if (errors.Any()) return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
