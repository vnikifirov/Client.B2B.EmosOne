using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Infrastructure.Services
{
    public interface IAccountService
    {
        bool Exists(string username);
        bool EmailExists(string email);
        void Activate(string username);
        void Deactivate(string username);
        void ChangePassword(string username, string oldPassword, string newPassword);
        bool ValidatePassword(string password);
    }
}
