using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Web.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateZadatak.Web.Controllers
{
    public class OsobaController : BoilerplateZadatakControllerBase
    {
        private readonly IOsobaService _osobaService;

        public OsobaController(IOsobaService osobaService)
        {
            _osobaService = osobaService;
        }

        public IActionResult Index()
        {
            var model = new OsobaModelDto(_osobaService);
            return View(model);
        }

        /// <summary>
        /// vraca osobu po unetom id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OsobaPoId(int id)
        {
            var osoba = _osobaService.EntitetPoId(id);
            return View(osoba);
        }

        public IActionResult NovaOsoba()
        {
            return View();
        }

        /// <summary>
        /// upisuje novu osobu u bazu
        /// </summary>
        /// <param name="novaOsoba"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NovaOsoba(OsobaDto novaOsoba)
        {
            _osobaService.DodajEntitet(novaOsoba);
            return RedirectToAction("Index");
        }

        public IActionResult IzmenaInfoOsobe()
        {
            return View();
        }

        /// <summary>
        /// menja info vec postojeceg entiteta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult IzmenaInfoOsobe(OsobaDto noviInfo)
        {
            _osobaService.IzmeniEntitet(noviInfo);
            return RedirectToAction("Index");
        }

        public IActionResult ObrisiOsobu()
        {
            return View();
        }

        /// <summary>
        /// akcija koja brise entitet iz baze
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ObrisiOsobu(int id)
        {
            _osobaService.ObrisiEntitet(id);
            return RedirectToAction("Index");
        }
    }
}