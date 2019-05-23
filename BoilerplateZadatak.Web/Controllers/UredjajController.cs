using System.Runtime.InteropServices.ComTypes;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Web.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateZadatak.Web.Controllers
{
    public class UredjajController : BoilerplateZadatakControllerBase
    {
        private readonly IUredjajService _uredjajService;

        public UredjajController(IUredjajService uredjajService)
        {
            _uredjajService = uredjajService;
        }

        public IActionResult Index()
        {
            var model = new UredjajModelDto(_uredjajService);
            return View(model);
        }

        /// <summary>
        /// vraca uredjaj sa datim ID-em
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult UredjajPoId(int id)
        {
            var osoba = _uredjajService.EntitetPoId(id);
            return View(osoba);
        }
        
        public IActionResult NoviUredjaj()
        {
            return View();
        }

        /// <summary>
        /// upisuje se novi uredjaj u bazu
        /// </summary>
        /// <param name="noviUredjaj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NoviUredjaj(UredjajDto noviUredjaj)
        {
            _uredjajService.DodajEntitet(noviUredjaj);
            return RedirectToAction("Index");
        }

        public IActionResult IzmenaInfoUredjaj()
        {
            return View();
        }

        /// <summary>
        /// metod koji pravi izmene na vec postojecem entitetu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult IzmenaInfoUredjaj(UredjajDto noviInfo)
        {
            _uredjajService.IzmeniEntitet(noviInfo);
            return RedirectToAction("Index");
        }

        public IActionResult ObrisiUredjaj()
        {
            return View();
        }

        /// <summary>
        /// akcija koja brise entitet
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ObrisiUredjaj(int id)
        {
            _uredjajService.ObrisiEntitet(id);
            return RedirectToAction("Index");
        }
    }
}
