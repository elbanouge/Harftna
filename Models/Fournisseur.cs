using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplicationHarftna.Models
{
    [Table("FOURNISSEUR")]
    public partial class Fournisseur
    {
        public Fournisseur()
        {
            Produits = new HashSet<Produit>();
        }

        [Key]
        [Column("IDFOUR")]
        public int Idfour { get; set; }
        [Column("NOMFOUR")]
        [StringLength(25)]
        public string Nomfour { get; set; }
        [Column("PRENOMFOUR")]
        [StringLength(25)]
        public string Prenomfour { get; set; }
        [Column("DOMAINEFOUR")]
        [StringLength(25)]
        public string Domainefour { get; set; }
        [Column("MOTPASSFOUR")]
        [StringLength(25)]
        public string Motpassfour { get; set; }
        [Column("FAXFOUR")]
        [StringLength(25)]
        public string Faxfour { get; set; }
        [Column("EMAILFOUR")]
        [StringLength(25)]
        public string Emailfour { get; set; }
        [Column("TELFOUR")]
        [StringLength(25)]
        public string Telfour { get; set; }
        [Column("CINPASSFOUR")]
        [StringLength(25)]
        public string Cinpassfour { get; set; }
        [Column("IMAGEFOUR", TypeName = "image")]
        public byte[] Imagefour { get; set; }
        [Column("EMAILVERIFIERFOUR")]
        public bool? Emailverifierfour { get; set; }

        [InverseProperty(nameof(Produit.IdfrsproNavigation))]
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
