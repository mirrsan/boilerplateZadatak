using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerplateZadatak.Models;

namespace BoilerplateZadatak.AppService.Dto
{
    [AutoMap(typeof(OsobaUredjaj))]
    public class OsobaUredjajDto : EntityDto
    {
        public DateTime PocetakKoriscenja { get; set; }
        public DateTime? KrajKoriscenja { get; set; }
        public OsobaDto Osoba { get; set; }
        public UredjajDto Uredjaj { get; set; }
    }
}
