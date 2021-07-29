using Emlak.Veri.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Emlak.Veri.DatabaseContexts.AutenticationDbContext
{

    public class AutenticationDbContext : IdentityDbContext<ApplicationUser>
    {
         public AutenticationDbContext(DbContextOption<AutenticationDbContext> options)
             :base(options)
             {

             }
    }
}