using System.Collections.Generic;
using Abp.Domain.Entities;

namespace BoilerplateZadatak.Models
{
    public class Kancelarija : Entity
    {
        public string Opis { get; set; }

        public List<Osoba> Osobe { get; set; }
    }
}
