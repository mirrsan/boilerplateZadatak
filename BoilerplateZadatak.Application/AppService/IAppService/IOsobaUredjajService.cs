using System.Collections.Generic;
using Abp.Application.Services;
using BoilerplateZadatak.AppService.Dto;

namespace BoilerplateZadatak.AppService.IAppService
{
    public interface IOsobaUredjajService : IApplicationService
    {
        IEnumerable<OsobaUredjajDto> DajSveEntitete();
        OsobaUredjajDto EntitetPoId(int id);
        int DodajEntitet(OsobaUredjajDto entitet);
        void IzmeniEntitet(OsobaUredjajDto entitet);
        void ObrisiEntitet(int id);
    }
}
