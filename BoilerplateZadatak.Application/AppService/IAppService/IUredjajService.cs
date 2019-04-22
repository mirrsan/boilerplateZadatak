using BoilerplateZadatak.AppService.Dto;
using System.Collections.Generic;
using Abp.Application.Services;

namespace BoilerplateZadatak.AppService.IAppService
{
    public interface IUredjajService : IApplicationService
    {
        IEnumerable<UredjajDto> DajSveEntitete();
        UredjajDto EntitetPoId(int id);
        int DodajEntitet(UredjajDto entitet);
        void IzmeniEntitet(UredjajDto entitet);
        void ObrisiEntitet(int id);
    }
}
