using System.Collections.Generic;
using Abp.Application.Services;
using BoilerplateZadatak.AppService.Dto;

namespace BoilerplateZadatak.AppService.IAppService
{
    public interface IKancelarijaService : IApplicationService
    {
        IEnumerable<KancelarijaDto> DajSveEntitete();
        KancelarijaDto EntitetPoId(int id);
        int DodajEntitet(KancelarijaDto entitet);
        void IzmeniEntitet(KancelarijaDto entitet);
        void ObrisiEntitet(int id);
    }
}
