using LoanManagementPaymentService.Interfaces;
using LoanManagementPaymentService.Models;

namespace LoanManagementPaymentService.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repo;

        public PaymentService(IPaymentRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<PaymentModels>> GetAllAsync() 
        { 
            return _repo.GetAllAsync(); 
        }

        public Task<PaymentModels> GetByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }

        public Task<PaymentModels> CreateAsync(PaymentModels model) 
        { 
            return _repo.CreateAsync(model); 
        }

        public Task UpdateAsync(PaymentModels model) 
        {
           return _repo.UpdateAsync(model); 
        }

        public Task DeleteAsync(int id) 
        {  
            return _repo.DeleteAsync(id); 
        }
    }
}
