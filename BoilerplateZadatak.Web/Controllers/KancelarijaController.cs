using System.Linq;
using BoilerplateZadatak.AppService.Dto;
using Microsoft.AspNetCore.Mvc;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Web.Dto;

namespace BoilerplateZadatak.Web.Controllers
{
    public class KancelarijaController : BoilerplateZadatakControllerBase
    {
        private readonly IKancelarijaService _kancelarijaService;

        public KancelarijaController(IKancelarijaService kancelarijaService)
        {
            _kancelarijaService = kancelarijaService;
        }

        public IActionResult Index()
        {
            var model = new KancelarijaModelDto(_kancelarijaService);
            return View(model);
        }

        /// <summary>
        /// vraca kancelariju po datom id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult KancelarijaPoId(int id)
        {
            var kancelarija = _kancelarijaService.EntitetPoId(id);
            return View(kancelarija);
        }

        public IActionResult NovaKancelarija()
        {
            return View();
        }

        /// <summary>
        /// akcija kreira novu kancelariju
        /// </summary>
        /// <param name="novaKancelarija"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NovaKancelarija(KancelarijaDto novaKancelarija)
        {
            _kancelarijaService.DodajEntitet(novaKancelarija);
            return RedirectToAction("Index");
        }

        public IActionResult IzmeniInfoKancelarije()
        {
            return View();
        }

        /// <summary>
        /// izmena info vec postojece kancelarije
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult IzmeniInfoKancelarije(KancelarijaDto noviInfo)
        {
            _kancelarijaService.IzmeniEntitet(noviInfo);
            return RedirectToAction("Index");
        }

        public IActionResult ObrisiKancelariju()
        {
            return View();
        }

        /// <summary>
        /// metod brise kancelariju iz baze
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ObrisiKancelariju(int id)
        {
            _kancelarijaService.ObrisiEntitet(id);
            return RedirectToAction("Index");
        }
    }
}