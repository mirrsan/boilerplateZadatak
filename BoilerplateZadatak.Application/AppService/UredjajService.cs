using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService
{
    public class UredjajService : BoilerplateZadatakAppServiceBase, IUredjajService
    {
        private readonly IRepository<Uredjaj> _repository;

        public UredjajService(IRepository<Uredjaj> repository)
        {
            _repository = repository;
        }

        public IEnumerable<UredjajDto> DajSveEntitete()
        {
            var svi = _repository.GetAll();
            var sviDto = ObjectMapper.Map<List<UredjajDto>>(svi);
            return sviDto;
        }

        public int DodajEntitet(UredjajDto entitet)
        {
            var uredjaj = ObjectMapper.Map<Uredjaj>(entitet);
            int id = _repository.InsertAndGetId(uredjaj);
            return id;
        }

        public UredjajDto EntitetPoId(int id)
        {
            try
            {
                var uredjaj = _repository.Get(id);
                var uredjajDto = ObjectMapper.Map<UredjajDto>(uredjaj);
                return uredjajDto;
            }
            catch (Exception e)
            {
                throw new UserFriendlyException("Uredjaj nije pronadjen");
            }
        }

        public void IzmeniEntitet(UredjajDto entitet)
        {
            _repository.Update(ObjectMapper.Map<Uredjaj>(entitet));
        }

        public void ObrisiEntitet(int id)
        {
            _repository.Delete(id);
        }
    }
}
