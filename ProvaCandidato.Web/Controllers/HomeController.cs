using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProvaCandidato.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.NomeEmpresa = ReadSetting("NomeEmpresa");
            return View();
        }

        string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return "";
            }
        }
    }
}