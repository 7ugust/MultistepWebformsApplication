using System.Web.Mvc;
using WebformsApplication.Models;

namespace WebformsApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RemovePerson();
            return PartialView();
        }

        private Person GetPerson()
        {
            if (Session["person"] == null)
            {
                Session["person"] = new Person();
            }
            return (Person)Session["person"];

        }

        private void RemovePerson()
        {
            if (Session["person"] != null)
            {
                Session.Remove("person");
            }
        }

        [HttpPost]
        public ActionResult PersonBasicInfo(PersonBasicInfo personData, string nextBtn)
        {
            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    Person obj = GetPerson();
                    obj.FirstName = personData.FirstName;
                    obj.LastName = personData.LastName;
                    return PartialView("PersonMoreInfo");
                }
            }
            return PartialView();
        }

        [HttpPost]
        public ActionResult PersonMoreInfo(PersonMoreInfo personData, string previousBtn, string nextBtn)
        {
            Person obj = GetPerson();

            if (previousBtn != null)
            {
                PersonBasicInfo pBasicInfo = new PersonBasicInfo();
                pBasicInfo.FirstName = obj.FirstName;
                pBasicInfo.LastName = obj.LastName;
                return PartialView("PersonBasicInfo", pBasicInfo);
            }

            if (nextBtn != null)
            {
                if (ModelState.IsValid)
                {
                    obj.street = personData.street;
                    obj.city = personData.city;
                    obj.state = personData.state;
                    obj.country = personData.country;
                    obj.postalcode = personData.postalcode;
                    obj.phone = personData.phone;
                    return PartialView("PersonInfo", obj);
                }
            }
            return PartialView();
        }


    }
}