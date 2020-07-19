using Activity2_Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2_Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> userList = new List<UserModel>();
            UserModel user1 = new UserModel("Kurt", "kurt@test.com", "123-456-7890");
            UserModel user2 = new UserModel("Nicholas", "nicholas@test.com", "321-654-0987");
            UserModel user3 = new UserModel("Ray", "ray@test.com", "098-765-4321");

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);


            


            return View("Test", userList);
        }
    }
}