using System.Collections.Generic;
using System.Linq;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;

namespace BoilerplateZadatak.Web.Dto
{
    public class OsobaModelDto
    {
        public List<OsobaDto> Osobe { get; set; }

        public OsobaModelDto(IOsobaService osobe)
        {
            Osobe = osobe.DajSveEntitete().ToList();
        }
    }
}
