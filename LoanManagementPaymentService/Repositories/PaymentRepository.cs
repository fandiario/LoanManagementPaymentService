using LoanManagementPaymentService.Data;
using LoanManagementPaymentService.Interfaces;
using LoanManagementPaymentService.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementPaymentService.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentModels>> GetAllAsync()
        { 
            return await _context.Payments.ToListAsync(); 
        }

        public async Task<PaymentModels> GetByIdAsync(int id)
        { 
            return await _context.Payments.FindAsync(id); 
        }

        public async Task<PaymentModels> CreateAsync(PaymentModels model)
        {
            _context.Payments.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(PaymentModels model)
        {
            _context.Payments.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var payment = await _context.Payments.FindAsync(id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
