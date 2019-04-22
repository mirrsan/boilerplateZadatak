using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplateZadatak.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OsobaUredjajController : Controller
    {
        private readonly IOsobaUredjajService _osobaUredjajService;

        public OsobaUredjajController(IOsobaUredjajService osobaUredjajService)
        {
            _osobaUredjajService = osobaUredjajService;
        }

        /// <summary>
        /// vraca sve entitete OsobaUredjaj
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SveOU()
        {
            var svi = _osobaUredjajService.DajSveEntitete();
            return Ok(svi);
        }

        /// <summary>
        /// vraca osobaUredjaj po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult OuPoId(int id)
        {
            var osobaUredjaj = _osobaUredjajService.EntitetPoId(id);
            return Ok(osobaUredjaj);
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
            return Ok($"Id upisanog entiteta je {id}");
        }

        /// <summary>
        /// menja info vez postojeceg osobaUredjaj entiteta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noviInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult IzmenaInfoOU(OsobaUredjajDto noviInfo)
        {
            _osobaUredjajService.IzmeniEntitet(noviInfo);
            return Ok("Izmenjeno");
        }

        /// <summary>
        /// brise osobaUredjaj entitet sa datim id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult ObrisiOU(int id)
        {
            _osobaUredjajService.ObrisiEntitet(id);
            return Ok("Obrisano");
        }
    }
}