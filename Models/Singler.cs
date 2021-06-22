using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("SINGLER")]
    public partial class Singler
    {
        [Key]
        [Column("IDCLISING")]
        public int Idclising { get; set; }
        [Key]
        [Column("IDPSING")]
        public int Idpsing { get; set; }
        [Column("MESSAGESSING", TypeName = "text")]
        public string Messagessing { get; set; }

        [ForeignKey(nameof(Idclising))]
        [InverseProperty(nameof(Client.Singlers))]
        public virtual Client IdclisingNavigation { get; set; }
        [ForeignKey(nameof(Idpsing))]
        [InverseProperty(nameof(Produit.Singlers))]
        public virtual Produit IdpsingNavigation { get; set; }
    }
}
