using Unit_Testing.Entites;
using Unit_Testing.Service;

namespace TestProject1
{

    public class Tests
    {
        private UserService userService;
        private ReserveService serveService;
        [SetUp]
        public void Setup()
        {
            userService = new UserService();
            serveService = new ReserveService();

        }
        [Test]

       public void CanCansel_owner_True()
        {
            //Arrenge
            UserEntity owner = new UserEntity()
            {
                FullName = "کاربر 1",
                Id = 1
            };
            ReserveEntity reserve = new ReserveEntity()
            {
                Id = 10,
                owner =owner,
                ownerId = 1,
                Status = ReserveEntity.ReserveStatus.PENNDING,
                Title = "هتل پردیس"
            };

            //Act
            bool result = serveService.CanselReserve(reserve , owner);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]

        public void CanCansel_Admin_True()
        {
            //Arrenge
            UserEntity owner = new UserEntity()
            {
                FullName = "کاربر 1",
                Id = 1
            };
            UserEntity admin = new UserEntity()
            {
                FullName = "ادمین",
                Id = 2
            };
            ReserveEntity reserve = new ReserveEntity()
            {
                Id = 10,
                owner = owner,
                ownerId = 1,
                Status = ReserveEntity.ReserveStatus.PENNDING,
                Title = "هتل پردیس"
            };
            userService = new UserService();
            userService.Admins.Add(new AdminEntity()
            {
                Id=1,
                User=admin,
                UserId=admin.Id,
                ExpireDate=DateTime.Now.AddDays(10)
            });
            //Act
            bool result = serveService.CanselReserve(reserve, admin , userService );
            //Assert
            Assert.IsTrue(result);
        }
    }
}