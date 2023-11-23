using DAT_Context;
using DAT_Services.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Repository
{
    public class AccountRepository : IAccountRepository
    {
        // DAT_Context _context;
        private readonly DAT_DbContext _context;
        public AccountRepository()
        {
                _context = new DAT_DbContext();
        }

        public bool ChangePassword(string username, string password, string newpassword, string renewpassword)
        {
            // đổi mật khẩu
            // nếu mật khẩu cũ không đúng thì thông báo lỗi
            // nếu mật khẩu mới và mật khẩu nhập lại không trùng nhau thì thông báo lỗi
            // nếu đổi mật khẩu thành công thì thông báo thành công
            // nếu đổi mật khẩu thất bại thì thông báo lỗi
            try
            {
                var account = _context.Accounts.FirstOrDefault(c => c.UserName == username && !c.IsDeleted);
                if (account.Password != password)
                {
                    throw new Exception("Mật khẩu cũ không đúng");
                }
                if (!newpassword.Equals(renewpassword))
                {
                    throw new Exception("Mật khẩu mới không trùng khớp");
                }
                account.Password = newpassword;
                _context.Entry(account).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool CheckUsername(string username)
        {
            // kiểm tra tên tài khoản
            // nếu đã tồn tại thì thông báo lỗi
            // nếu chưa tồn tại thì đăng kí
            try
            {
                var result = _context.Accounts.Any(c => c.UserName == username && !c.IsDeleted);
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool EditAccount(Account account)
        {
            // sửa thông tin tài khoản
            // nếu sửa thành công thì thông báo thành công
            // nếu sửa thất bại thì thông báo lỗi
            try
            {
                _context.Entry(account).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Account GetAccount(string username)
        {
            // lấy thông tin tài khoản
            // nếu tài khoản không tồn tại thì thông báo lỗi
            // nếu tài khoản tồn tại thì lấy thông tin tài khoản
            try
            {
                var result = _context.Accounts.FirstOrDefault(c => c.UserName == username && !c.IsDeleted);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Login(string username, string password)
        {
            // nếu đúng tên tài khoản và mật khẩu thì đăng nhập
            // nếu sai thì thông báo lỗi
           return _context.Accounts.Any(c => c.UserName.Equals(username) && c.Password.Equals(password) && !c.IsDeleted);
        }

        public bool Register(string username, string password, string repasswords)
        {
            // create new account
            // save to database
            // return true if success
            // return false if fail
            try
            {
                var newAccount = new Account()
                {
                    UserName = username,
                    Password = password,
                    RolesId = null,
                };
                 _context.Accounts.Add(newAccount);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
