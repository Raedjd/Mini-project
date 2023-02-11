using System.Threading.Tasks;

namespace microservice_.Net.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
