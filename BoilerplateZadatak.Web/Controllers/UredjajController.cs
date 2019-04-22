using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateZadatak.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UredjajController : Controller
    {
        private readonly IUredjajService _uredjajService;

        public UredjajController(IUredjajService uredjajService)
        {
            _uredjajService = uredjajService;
        }

        /// <summary>
        /// vraca sve uredjaje
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SviUredjaji()
        {
            var svi = _uredjajService.DajSveEntitete();
            return Ok(svi);
        }

        /// <summary>
        /// vraca uredjaj sa datim ID-em
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult UredjajPoId(int id)
        {
            var osoba = _uredjajService.EntitetPoId(id);
            return Ok(osoba);
        }

        /// <summary>
        /// upisuje se novi uredjaj u bazu
        /// </summary>
        /// <param name="noviUredjaj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NoviUredjaj(UredjajDto noviUredjaj)
        {
            int id = _uredjajService.DodajEntitet(noviUredjaj);
            return Ok($"Id od'{noviUredjaj.Naziv}' je {id}.");
        }

        /// <summary>
        /// metod koji pravi izmene na vec postojecem entitetu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult IzmenaInfoUredjaj(UredjajDto noviInfo)
        {
            _uredjajService.IzmeniEntitet(noviInfo);
            return Ok("Uspesno izmenjeno.");
        }

        /// <summary>
        /// akcija koja brise entitet
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}:int")]
        public IActionResult ObrisiUredjaj(int id)
        {
            _uredjajService.ObrisiEntitet(id);
            return Ok("Uspesno izbrisano");
        }
    }
}
