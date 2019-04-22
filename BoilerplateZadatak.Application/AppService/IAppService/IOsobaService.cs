using System.Collections.Generic;
using Abp.Application.Services;
using BoilerplateZadatak.AppService.Dto;

namespace BoilerplateZadatak.AppService.IAppService
{
    public interface IOsobaService : IApplicationService
    {
        IEnumerable<OsobaDto> DajSveEntitete();
        OsobaDto EntitetPoId(int id);
        int DodajEntitet(OsobaDto entitet);
        void IzmeniEntitet(OsobaDto entitet);
        void ObrisiEntitet(int id);
    }
}
