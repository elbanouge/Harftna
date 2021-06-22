using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("INFORMATIONPERSONNELLE")]
    public partial class Informationpersonnelle
    {
        public Informationpersonnelle()
        {
            Commanders = new HashSet<Commander>();
        }

        [Key]
        [Column("IDINFO")]
        public int Idinfo { get; set; }
        [Column("IDCLIINFO")]
        public int? Idcliinfo { get; set; }
        [Column("ADRESSECLIINFO", TypeName = "text")]
        public string Adressecliinfo { get; set; }
        [Column("PAYSCLIINFO")]
        [StringLength(25)]
        public string Payscliinfo { get; set; }
        [Column("CODEPOSTALCLIINFO")]
        [StringLength(25)]
        public string Codepostalcliinfo { get; set; }

        [ForeignKey(nameof(Idcliinfo))]
        [InverseProperty(nameof(Client.Informationpersonnelles))]
        public virtual Client IdcliinfoNavigation { get; set; }
        [InverseProperty(nameof(Commander.IdinfocomNavigation))]
        public virtual ICollection<Commander> Commanders { get; set; }
    }
}
