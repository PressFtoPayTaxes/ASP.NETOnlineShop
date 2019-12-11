using OnlineShop.DTO;
using OnlineShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class TwilioSmsService : ISmsService
    {
        public Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber, string code)
        {
            return Task.FromResult(new SmsServiceResponseDTO { 
                StatusCode = 200,
                Message = "Сообщение успешно отправлено"
            });
        }
    }
}
