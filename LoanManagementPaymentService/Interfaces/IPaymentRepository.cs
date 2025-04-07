using LoanManagementPaymentService.Models;

namespace LoanManagementPaymentService.Interfaces
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<PaymentModels>> GetAllAsync();
        Task<PaymentModels> GetByIdAsync(int id);
        Task<PaymentModels> CreateAsync(PaymentModels model);
        Task UpdateAsync(PaymentModels model);
        Task DeleteAsync(int id);
    }
}
