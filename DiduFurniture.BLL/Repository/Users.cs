using DiduFurniture.DAL;
using DiduFurniture.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DiduFurniture.BLL.Repository;

namespace DiduFurniture.BLL.Repository
{
    public class Users : IUsers
    {
        private DiduContext _context;
        public Users(DiduContext _diduContext)
        {
            _context = _diduContext;
        }
        public bool changeUserPassword(string pass, string username)
        {
            var list = _context.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (list == null)
            {
                return false;
            }
            else
            {
                list.Password = pass;
                _context.Update(list);
                _context.SaveChanges();
                return true;
            }
        }
        public bool Login(string pass, string username)
        {
            var list = _context.Users.Where(x => x.UserName == username && x.Password==pass).FirstOrDefault();
            if (list == null)
            {
                return false;
            }
            else
            {

                return true;
            }
        }
    }
}
