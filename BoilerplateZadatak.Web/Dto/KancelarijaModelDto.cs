using System.Collections.Generic;
using System.Linq;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;

namespace BoilerplateZadatak.Web.Dto
{
    public class KancelarijaModelDto
    {
        public List<KancelarijaDto> Kancelarije { get; set; }

        public KancelarijaModelDto(IKancelarijaService kancelarije)
        {
            Kancelarije = kancelarije.DajSveEntitete().ToList();
        }
    }
}
