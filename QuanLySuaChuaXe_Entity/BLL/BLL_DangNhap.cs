using System;
using System.Linq;
using System.Data;
using QuanLySuaChuaXe_Entity;

namespace BLL
{
    public class BLL_DangNhap
    {
        public BLL_DangNhap() { }

        public bool AuthenticateUser(string username, string password)
        {
            int count = 0;
            try
            {
                using (QuanLySuaChuaXeEntities quanly_SuaChuaXe = new QuanLySuaChuaXeEntities())
                {
                    var result = from user in quanly_SuaChuaXe.Users
                                    where
                                        user.User_name == username.Trim() &&
                                        user.Password == password.Trim()
                                    select user;

                    count = result.Count();
                }
            }
            catch
            {
                return false;
            }
            return count > 0;
        }
    }
    
}
