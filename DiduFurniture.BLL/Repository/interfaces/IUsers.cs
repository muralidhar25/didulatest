using DiduFurniture.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiduFurniture.BLL.Repository
{
   public interface IUsers
    {
        bool changeUserPassword(string pass, string username);
        bool Login(string pass, string username);
    }
}
