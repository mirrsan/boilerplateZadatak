using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateZadatak.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OsobaController : Controller
    {
        private readonly IOsobaService _osobaService;

        public OsobaController(IOsobaService osobaService)
        {
            _osobaService = osobaService;
        }

        /// <summary>
        /// vraca sve osobe
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SveOsobe()
        {
            var svi = _osobaService.DajSveEntitete();
            return Ok(svi);
        }

        /// <summary>
        /// vraca osobu po unetom id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult OsobaPoId(int id)
        {
            var osoba = _osobaService.EntitetPoId(id);
            return Ok(osoba);
        }

        /// <summary>
        /// upisuje novu osobu u bazu
        /// </summary>
        /// <param name="novaOsoba"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NovaOsoba(OsobaDto novaOsoba)
        {
            int id = _osobaService.DodajEntitet(novaOsoba);
            return Ok($"Id {novaOsoba.Ime}-{novaOsoba.Prezime} je {id}");
        }

        /// <summary>
        /// menja info vec postojeceg entiteta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult IzmenaInfoOsobe(OsobaDto noviInfo)
        {
            _osobaService.IzmeniEntitet(noviInfo);
            return Ok("Izmenjeno");
        }

        /// <summary>
        /// akcija koja brise entitet iz baze
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}:int")]
        public IActionResult ObrisiOsobu(int id)
        {
            _osobaService.ObrisiEntitet(id);
            return Ok("Obrisano!");
        }
    }
}