using System;
using Xunit;
using DiduFurnitureAPI.Controllers;
using DiduFurniture.BLL.Repository;

namespace DiduFurniture.UnitTest
{
    public class UnitTest1
    {
        UsersController _usersController;
        Users _user;

        [Fact]
        public void Test1()
        {
            // Act
            var okResult = _user.changeUserPassword(" ", " ");
            // Assert
            Assert.False(okResult);
        }
    }
   
}
