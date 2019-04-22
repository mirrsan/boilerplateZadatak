using BoilerplateZadatak.AppService.Dto;
using Microsoft.AspNetCore.Mvc;
using BoilerplateZadatak.AppService.IAppService;

namespace BoilerplateZadatak.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class KancelarijaController : Controller
    {
        private readonly IKancelarijaService _kancelarijaService;

        public KancelarijaController(IKancelarijaService kancelarijaService)
        {
            _kancelarijaService = kancelarijaService;
        }
        
        /// <summary>
        /// vraca sve kancelarije
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SveKancelarije()
        {
            var sve = _kancelarijaService.DajSveEntitete();
            return Ok(sve);
        }

        /// <summary>
        /// vraca kancelariju po datom id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult KancelarijaPoId(int id)
        {
            var kancelarija = _kancelarijaService.EntitetPoId(id);
            return Ok(kancelarija);
        }

        /// <summary>
        /// akcija kreira novu kancelariju
        /// </summary>
        /// <param name="novaKancelarija"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NovaKancelarija(KancelarijaDto novaKancelarija)
        {
            int id = _kancelarijaService.DodajEntitet(novaKancelarija);
            return Ok($"{novaKancelarija.Opis} ima ID = {id}");
        }

        /// <summary>
        /// izmena info vec postojece kancelarije
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult IzmeniInfoKancelarije(KancelarijaDto noviInfo)
        {
            _kancelarijaService.IzmeniEntitet(noviInfo);
            return Ok("Izmenili ste izmene, svaka cass");
        }

        /// <summary>
        /// metod brise kancelariju iz baze
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult ObrisiKancelariju(int id)
        {
            _kancelarijaService.ObrisiEntitet(id);
            return Ok("Obrisana je");
        }
    }
}