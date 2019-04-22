using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService.Dto
{
    [AutoMap(typeof(Kancelarija))]
    public class KancelarijaDto : EntityDto
    {
        public string Opis { get; set; }
    }
}
