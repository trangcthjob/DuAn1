using DAT_Services.IRepository;
using DAT_Services.IServices;
using DAT_Services.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Services
{
    public class AccountServices : IAccountServices
    {
        // Repository
        private readonly IAccountRepository _accountRepository = new AccountRepository();
        public AccountServices()
        {
        }

        public string ChangePassword(string username, string password, string newpassword, string renewpassword)
        {
            return _accountRepository.ChangePassword(username, password, newpassword, renewpassword);
        }

        public bool CheckUsername(string username)
        {
            return _accountRepository.CheckUsername(username);
        }

        public bool EditAccount(Account account)
        {
            return _accountRepository.EditAccount(account);
        }

        public Account GetAccount(string username)
        {
            return _accountRepository.GetAccount(username);
        }

        public bool Login(string username, string password)
        {
            return  _accountRepository.Login(username, password);
        }

        public bool Register(string username, string password, string repassword)
        {
            // nếu 2 mật khẩu không trùng nhau thì thông báo lỗi
            if (!password.Equals(repassword))
            {
                throw new Exception("Mật khẩu không trùng khớp");
            }
            // nếu đã tồn tài tài khoản thì thông báo lỗi
            if (_accountRepository.CheckUsername(username))
            {
                throw new Exception("Tài khoản đã tồn tại");
            }
            return _accountRepository.Register(username, password, repassword);
        }
    }
}
