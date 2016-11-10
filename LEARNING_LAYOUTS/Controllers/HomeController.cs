using System.Linq;
//using System.Data.Entity;

namespace LEARNING_LAYOUTS.Controllers
{
	public partial class HomeController : System.Web.Mvc.Controller
	{
		/// <summary>
		/// Step (1)
		/// </summary>
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_01()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_02()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_03()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_04()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_05()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_06()
		{
			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_07()
		{
			return (View());
		}

		/// <summary>
		/// Step (2)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_08()
		{
			ViewBag.SomeVariable1 = "Some Variable 1!";

			return (View());
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn_09()
		{
			return (View());
		}
	}
}
