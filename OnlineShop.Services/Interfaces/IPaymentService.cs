using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain;
using OnlineShop.DTO;

namespace OnlineShop.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentServiceResponseDTO> CreateInvoice(Order order);
    }
}
