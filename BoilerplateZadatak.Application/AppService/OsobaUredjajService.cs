using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.UI;
using BoilerplateZadatak.AppService.Dto;
using BoilerplateZadatak.AppService.IAppService;
using BoilerplateZadatak.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateZadatak.AppService
{
    public class OsobaUredjajService : BoilerplateZadatakAppServiceBase, IOsobaUredjajService
    {
        private readonly IRepository<OsobaUredjaj> _repository;

        public OsobaUredjajService(IRepository<OsobaUredjaj> repository)
        {
            _repository = repository;
        }

        public IEnumerable<OsobaUredjajDto> DajSveEntitete()
        {
            var svi = _repository.GetAllIncluding(o => o.Osoba, u => u.Uredjaj, k => k.Osoba.Kancelarija);
            var sviDto = ObjectMapper.Map<List<OsobaUredjajDto>>(svi);
            return sviDto;
        }

        public int DodajEntitet(OsobaUredjajDto entitet)
        {
            var osobaUredjaj = ObjectMapper.Map<OsobaUredjaj>(entitet);
            int id = _repository.InsertAndGetId(osobaUredjaj);
            return id;
        }

        public OsobaUredjajDto EntitetPoId(int id)
        {
            foreach (var osobaUredjaj in DajSveEntitete())
            {
                if (osobaUredjaj.Id == id)
                {
                    var osobaUredjajDto = ObjectMapper.Map<OsobaUredjajDto>(osobaUredjaj);
                    return osobaUredjajDto;
                }
            }

            throw new UserFriendlyException("Nije pronadjen entitet sa datim id");

        }

        public void IzmeniEntitet(OsobaUredjajDto entitet)
        {
            _repository.Update(ObjectMapper.Map<OsobaUredjaj>(entitet));
        }

        public void ObrisiEntitet(int id)
        {
            _repository.Delete(id);
        }
    }
}
