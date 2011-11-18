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
    public class ClamController : Controller
    {
    	private ISessionFactory _sessionFactory;

    	public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Create(Clam clam)
        {
        	clam.UserName = User.Identity.Name;
			
			using(ISession session = SessionFactory.OpenSession())
			{
				session.Save(clam);
				session.Flush();
			}

        	return RedirectToAction("index", "home");
        }
        
    	protected ISessionFactory SessionFactory
    	{
			get
			{
				if (_sessionFactory == null)
				{
					var configuration = new Configuration();
					configuration.Configure();
					configuration.AddAssembly(typeof (Clam).Assembly);
					_sessionFactory = configuration.BuildSessionFactory();
				}
				return _sessionFactory;
			}
    	}
    }
}
