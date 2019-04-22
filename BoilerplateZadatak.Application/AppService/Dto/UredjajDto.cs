using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService.Dto
{
    [AutoMap(typeof(Uredjaj))]
    public class UredjajDto : EntityDto
    {
        public string Naziv { get; set; }
    }
}
