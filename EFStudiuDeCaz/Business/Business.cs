﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStudiuDeCaz.Business
{
    [Table("Business", Schema = "BazaDeDate")]
    public class Business
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessId { get; protected set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
    }

}
