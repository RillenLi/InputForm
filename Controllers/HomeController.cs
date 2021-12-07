using InputForm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using InputForm.DAL;

namespace InputForm.Controllers
{
    public class HomeController : Controller
    {

        IPersRepository pc;

        public HomeController(PensionContext context)
        {
            pc = new SQLPersRepository(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(pc.GetPeople());
        }
       
        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string snils, string surname, string name, string patronymic, DateTime date)
        {
            PersSaving Saving = pc.GetSavingbySnils(snils);
            bool validRes = ValidateUserData(Saving, surname, name, patronymic, date);
            if (Saving == null)
            {
                Saving = new PersSaving(snils);
            }

            return validRes ? View("Answer", Saving) : View("ErrorUser", snils);
        }

        [HttpGet]
        public IActionResult Answer()
        {
            return View();
        }

        private bool ValidateUserData(PersSaving persSaving, string surname, string name, string patronymic, DateTime date)
        {
            if (persSaving == null) return true;
            if (persSaving.Person.BirthDate.Date != date)
            {
                return false;
            }
            if (!persSaving.Person.Surname.Equals(surname.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            if (!persSaving.Person.Name.Equals(name.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            if (!persSaving.Person.Patronymic.Equals(patronymic.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}
