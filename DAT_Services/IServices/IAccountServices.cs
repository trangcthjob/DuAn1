using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IServices
{
    public interface IAccountServices
    {
        // đăng nhập
        public bool Login(string username, string password);
        // đăng kí
        public bool Register(string username, string password, string repassword);
        // Kiểm tra tên tài khoản
        public bool CheckUsername(string username);
        // lấy thông tin tài khoản
        public Account GetAccount(string username);
        // Sửa thông tin tài khoản
        public bool EditAccount(Account account);
        // đổi mật khẩu
        public string ChangePassword(string username, string password, string newpassword, string renewpassword);
    }
}
