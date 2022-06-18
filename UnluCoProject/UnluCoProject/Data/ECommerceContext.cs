using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UnluCoProject.Models;

namespace UnluCoProject.Data
{
    public class ECommerceContext : IdentityDbContext<User>
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {

        }
    }
}
