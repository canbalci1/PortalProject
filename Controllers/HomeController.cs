using System.Web.Mvc;
using PortalProject.Abstract;
using PortalProject.Adapter;
using PortalProject.Concrete;
using PortalProject.Entites;
using PortalProject.Models;

namespace PortalProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CustomerViewModel model)
        {
            Customer customer = new Customer()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthYear = model.BirthYear,
                IdentyNumber = model.NationalityId
            };

            //Sturbucs mernis dogrulamalı
            BaseCustomer baseCustomer = new Starbucks(new MernisAdapter());
            //Portal mernis doğrulaması yok, eğer isteniyorsa MernisAdapter yollanarak işlem çözülmüş olacaktır.
            BaseCustomer _baseCustomer = new Portal(new CustomerCheckManager());

            var _saveMethod = baseCustomer.Save(customer);

            ViewBag.SaveResult = _saveMethod.responseMessage;

            return View();

        }
    }
}