using System.Collections.Generic;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService
{
    public class OsobaService : BoilerplateZadatakAppServiceBase, IOsobaService
    {
        private readonly IRepository<Osoba> _repository;

        public OsobaService(IRepository<Osoba> repository)
        {
            _repository = repository;
        }

        public IEnumerable<OsobaDto> DajSveEntitete()
        {
            var sve = _repository.GetAllIncluding(k => k.Kancelarija);
            var sveDto = ObjectMapper.Map<List<OsobaDto>>(sve);
            return sveDto;
        }

        public int DodajEntitet(OsobaDto entitet)
        {
            var osoba = ObjectMapper.Map<Osoba>(entitet);
            int id = _repository.InsertAndGetId(osoba);
            return id;
        }

        public OsobaDto EntitetPoId(int id)
        {
            foreach (var o in DajSveEntitete())
            {
                if (o.Id == id)
                {
                    var osobaDto = ObjectMapper.Map<OsobaDto>(o);
                    return osobaDto;
                }
            }
            throw new UserFriendlyException("Nema sa tim ID");
        }

        public void IzmeniEntitet(OsobaDto entitet)
        {
            _repository.Update(ObjectMapper.Map<Osoba>(entitet));
        }

        public void ObrisiEntitet(int id)
        {
            _repository.Delete(id);
        }
    }
}
