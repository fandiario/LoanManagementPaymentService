using LoanManagementPaymentService.Models;

namespace LoanManagementPaymentService.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentModels>> GetAllAsync();
        Task<PaymentModels> GetByIdAsync(int id);
        Task<PaymentModels> CreateAsync(PaymentModels model);
        Task UpdateAsync(PaymentModels model);
        Task DeleteAsync(int id);
    }
}
