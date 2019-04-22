using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService.Dto
{
    [AutoMap(typeof(Osoba))]
    public class OsobaDto : EntityDto
    {
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public KancelarijaDto Kancelarija { get; set; }
    }
}
