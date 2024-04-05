using Leetcode_Domain.Entities;                 // Problem, Submissions, Tests, Users |ishlashi uchun
using Microsoft.EntityFrameworkCore;            // DbSet |ishlashi uchun

namespace Leetcode.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Problem> Problems { get; set; }
        DbSet<Submission> Submissions { get; set; }
        DbSet<Test> Tests { get; set; }
        DbSet<User> Users { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
