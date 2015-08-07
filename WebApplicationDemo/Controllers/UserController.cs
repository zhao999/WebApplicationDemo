using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationModel;
using WebApplicationServices;

namespace WebApplicationDemo.Controllers
{
    public class UserController : Controller
    {
        //todo 这里可以使用ioc的框架，简单写
        UserManager manger = new UserManager();
        //
        // GET: /User/
        public ActionResult Index()
        {
            var list = manger.GetAll();
            return View(list);
        }
        public ActionResult GetList(int groupId)
        {
            var list = manger.GetUsers(groupId);
            return Json(list);
        }
        public ActionResult Add()
        {
            var user = new User();
            return View(user);
        }
        [HttpPost]
        public ActionResult Add(User user)
        {
            var result = manger.AddUser(user);
            return Json(new { ret = result });
        }
        public ActionResult Delete(int userId)
        {
            var result =manger.DeleteUser(userId);
            return Json(new { ret = result });
        }
	}
}