using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace BoilerplateZadatak.Models
{
    public class OsobaUredjaj : Entity
    {
        public DateTime PocetakKoriscenja { get; set; }
        public DateTime? KrajKoriscenja { get; set; }

        public int OsobaId { get; set; }
        public int UredjajId { get; set; }

        [ForeignKey("OsobaId")]
        public Osoba Osoba { get; set; }

        [ForeignKey("UredjajId")]
        public Uredjaj Uredjaj { get; set; }
    }
}
