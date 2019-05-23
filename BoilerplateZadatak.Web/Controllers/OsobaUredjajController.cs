using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Web.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateZadatak.Web.Controllers
{
    public class OsobaUredjajController : BoilerplateZadatakControllerBase
    {
        private readonly IOsobaUredjajService _osobaUredjajService;

        public OsobaUredjajController(IOsobaUredjajService osobaUredjajService)
        {
            _osobaUredjajService = osobaUredjajService;
        }

        public IActionResult Index()
        {
            var model = new OsobaUredjajModelDto(_osobaUredjajService);
            return View(model);
        }

        /// <summary>
        /// vraca osobaUredjaj po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OuPoId(int? id)
        {
            var osobaUredjaj = _osobaUredjajService.EntitetPoId(id.Value);
            return View(osobaUredjaj);
        }

        public IActionResult NoviOsobaUredjaj()
        {
            return View();
        }

        /// <summary>
        /// metod upisuje novi OsobaUredjaj
        /// </summary>
        /// <param name="noviOU"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NoviOsobaUredjaj(OsobaUredjajDto noviOU)
        {
            int id = _osobaUredjajService.DodajEntitet(noviOU);
            return RedirectToAction("Index");
        }

        public IActionResult IzmenaInfoOU()
        {
            return View();
        }

        /// <summary>
        /// menja info vez postojeceg osobaUredjaj entiteta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult IzmenaInfoOU(OsobaUredjajDto noviInfo)
        {
            _osobaUredjajService.IzmeniEntitet(noviInfo);
            return RedirectToAction("Index");
        }

        public IActionResult ObrisiOU()
        {
            return View();
        }

        /// <summary>
        /// brise osobaUredjaj entitet sa datim id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ObrisiOU(int id)
        {
            _osobaUredjajService.ObrisiEntitet(id);
            return RedirectToAction("Index");
        }
    }
}