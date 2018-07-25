using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL_Net_Azure_01_Cap3.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
