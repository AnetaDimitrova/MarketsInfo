using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MarketsInfo.Models
{
    

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public System.Data.Entity.DbSet<MarketsInfo.Models.News> News { get; set; }
        public System.Data.Entity.DbSet<MarketsInfo.Models.StockInfo> Stocks { get; set; }
        public System.Data.Entity.DbSet<MarketsInfo.Models.Comment> Comments { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

       
    }
}