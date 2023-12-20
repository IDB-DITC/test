using ExampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {

		IRepository repo;
		//public HomeController()
		//{
		//	repo = Repository.Current;
		//}


		public HomeController(IRepository _repo)
		{
			repo = _repo;
		}



		public ActionResult Index()
		{
			return View(repo.Products);
		}
	}
}