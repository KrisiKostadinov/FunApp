using FunApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FunApp.Data
{
    public class FunAppContext : IdentityDbContext<FunAppUser>
    {
        public FunAppContext(DbContextOptions<FunAppContext> options) : base(options)
        {
        }
    }
}
