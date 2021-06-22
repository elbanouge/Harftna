using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("AVIS")]
    public partial class Avi
    {
        [Key]
        [Column("IDCLIAVI")]
        public int Idcliavi { get; set; }
        [Key]
        [Column("IDPAVI")]
        public int Idpavi { get; set; }
        [Column("COMMETNAVI", TypeName = "text")]
        public string Commetnavi { get; set; }
        [Column("ETOILEAVI")]
        public int? Etoileavi { get; set; }

        [ForeignKey(nameof(Idcliavi))]
        [InverseProperty(nameof(Client.Avis))]
        public virtual Client IdcliaviNavigation { get; set; }
        [ForeignKey(nameof(Idpavi))]
        [InverseProperty(nameof(Produit.Avis))]
        public virtual Produit IdpaviNavigation { get; set; }
    }
}
