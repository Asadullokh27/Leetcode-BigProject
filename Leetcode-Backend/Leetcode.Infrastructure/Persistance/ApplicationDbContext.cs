using Leetcode.Application.Abstractions;        // IApplicationDbContext |ishlashi uchun
using Leetcode_Domain.Entities;                 // Problem, Submissions, Tests, Users |ishlashi uchun
using Microsoft.EntityFrameworkCore;            // DbContext |ishlashi uchun

namespace Leetcode.Infrastructure.Persistance
{
    public class ApplicationDbContext:DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Problem> Problems { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
