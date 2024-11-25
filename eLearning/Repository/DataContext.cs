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
        public DbSet<EnrollmentFormModel> EnrollmentForm { get; set; }
        public DbSet<EnrollmentDetailsModel> EnrollmentDetails { get; set; }
        public DbSet<FieldModel> Fields { get; set; }
        public DbSet<AddressModel> Address { get; set; }
    }
}
