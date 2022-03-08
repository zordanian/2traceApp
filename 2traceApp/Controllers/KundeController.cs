using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2traceApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _2traceApp.Controllers
{
    public class KundeController : Controller
    {
        // GET: KundeController
        public ActionResult Kunde()
        {
            Kunde kunde = new Kunde();
            kunde.Navn = "Simon Zorde";
            kunde.Adresse = "Jægersborggade 16, 3. th";
            kunde.Telefonummer = "29724034";

            return View(kunde);
        }

    }
}
