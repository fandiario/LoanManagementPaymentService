using Microsoft.EntityFrameworkCore;
using LoanManagementPaymentService.Models;

namespace LoanManagementPaymentService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<PaymentModels> Payments { get; set; }
    }
}
