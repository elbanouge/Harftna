using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("CLIENT")]
    public partial class Client
    {
        public Client()
        {
            Avis = new HashSet<Avi>();
            Informationpersonnelles = new HashSet<Informationpersonnelle>();
            Singlers = new HashSet<Singler>();
        }

        [Key]
        [Column("IDCLI")]
        public int Idcli { get; set; }
        [Column("NOMCLI")]
        [StringLength(25)]
        public string Nomcli { get; set; }
        [Column("PRENOMCLI")]
        [StringLength(25)]
        public string Prenomcli { get; set; }
        [Column("MOTPASSCLI")]
        [StringLength(25)]
        public string Motpasscli { get; set; }
        [Column("EMAILCLI")]
        [StringLength(25)]
        public string Emailcli { get; set; }
        [Column("TELCLI")]
        [StringLength(25)]
        public string Telcli { get; set; }
        [Column("CINPASSCLI")]
        [StringLength(25)]
        public string Cinpasscli { get; set; }
        [Column("IMAGECLI", TypeName = "image")]
        public byte[] Imagecli { get; set; }
        [Column("SCORECLI")]
        [StringLength(25)]
        public string Scorecli { get; set; }
        [Column("IPCLI")]
        [StringLength(25)]
        public string Ipcli { get; set; }
        [Column("EMAILVERIFIER")]
        public bool? Emailverifier { get; set; }
        [Column("DATECREATE", TypeName = "datetime")]
        public DateTime? Datecreate { get; set; }

        [InverseProperty(nameof(Avi.IdcliaviNavigation))]
        public virtual ICollection<Avi> Avis { get; set; }
        [InverseProperty(nameof(Informationpersonnelle.IdcliinfoNavigation))]
        public virtual ICollection<Informationpersonnelle> Informationpersonnelles { get; set; }
        [InverseProperty(nameof(Singler.IdclisingNavigation))]
        public virtual ICollection<Singler> Singlers { get; set; }
    }
}
