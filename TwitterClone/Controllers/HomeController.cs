using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Cfg;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
	[HandleError]
	public class HomeController : Controller
	{
		private ISessionFactory _sessionFactory;

		public ActionResult Index()
		{
			ViewData["clams"] = SessionFactory.OpenSession().QueryOver<Clam>().List().Reverse();
			return View();
		}

		protected ISessionFactory SessionFactory
		{
			get
			{
				if (_sessionFactory == null)
				{
					var configuration = new Configuration();
					configuration.Configure();
					configuration.AddAssembly(typeof(Clam).Assembly);
					_sessionFactory = configuration.BuildSessionFactory();
				}
				return _sessionFactory;
			}
		}
	}


}
