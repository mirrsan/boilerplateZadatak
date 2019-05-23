using System.Collections.Generic;
using System.Linq;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;

namespace BoilerplateZadatak.Web.Dto
{
    public class UredjajModelDto
    {
        public List<UredjajDto> Uredjaj { get; set; }

        public UredjajModelDto(IUredjajService uredjaj)
        {
            Uredjaj = uredjaj.DajSveEntitete().ToList();
        }
    }
}
