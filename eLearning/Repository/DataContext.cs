using eLearning.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace eLearning.Repository
{
    public class DataContext : IdentityDbContext<IdentityUserModel>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
