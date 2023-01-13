using İstanbulAkademi_Template_DesignPattern.DAL.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace İstanbulAkademi_Template_DesignPattern.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MELEK;initial catalog=ZTemplateDesignDB;integrated security=true");
        }
    }
}

