using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace BoilerplateZadatak.Models
{
    public class Osoba : Entity
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public int KancelarijaId { get; set; }

        [ForeignKey("KancelarijaId")]
        public Kancelarija Kancelarija { get; set; }

        public List<OsobaUredjaj> OsobaUredjaji { get; set; }
    }
}
