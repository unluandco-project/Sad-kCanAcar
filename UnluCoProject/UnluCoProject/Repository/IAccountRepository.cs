using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using UnluCoProject.Models;

namespace UnluCoProject.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
    }
}
