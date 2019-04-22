using System;
using System.Collections.Generic;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService
{
    public class KancelarijaService : BoilerplateZadatakAppServiceBase, IKancelarijaService
    {
        private readonly IRepository<Kancelarija> _repository;
        
        public KancelarijaService(IRepository<Kancelarija> repository)
        {
            _repository = repository;
        }

        public IEnumerable<KancelarijaDto> DajSveEntitete()
        {
            var svi = _repository.GetAll();
            var sviDto = ObjectMapper.Map<List<KancelarijaDto>>(svi);
            return sviDto;
        }

        public int DodajEntitet(KancelarijaDto entitet)
        {
            var kancelarija = ObjectMapper.Map<Kancelarija>(entitet);
            var id = _repository.InsertAndGetId(kancelarija);
            return id;
        }

        public KancelarijaDto EntitetPoId(int id)
        {
            try
            {
                var kancelarija = _repository.Get(id);
                var kancelarijaDto = ObjectMapper.Map<KancelarijaDto>(kancelarija);
                return kancelarijaDto;
            }
            catch (Exception e)
            {
                throw new UserFriendlyException("Nema podataka sa datim ID");
            }
        }

        public void IzmeniEntitet(KancelarijaDto entitet)
        {
            _repository.Update(ObjectMapper.Map<Kancelarija>(entitet));
        }

        public void ObrisiEntitet(int id)
        {
            _repository.Delete(id);
        }
    }
}
