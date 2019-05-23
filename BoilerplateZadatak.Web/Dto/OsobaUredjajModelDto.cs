using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;

namespace BoilerplateZadatak.Web.Dto
{
    public class OsobaUredjajModelDto
    {
        public List<OsobaUredjajDto> OsobaUredjaj { get; set; }

        public OsobaUredjajModelDto(IOsobaUredjajService osobaUredjaj)
        {
            OsobaUredjaj = osobaUredjaj.DajSveEntitete().ToList();
        }
    }
}
