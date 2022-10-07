using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   [Table("NpaKindsRef")]
   public class NpaKindsRef {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      [MaxLength(256)]
      [Display(Name ="Вид НПА")]
      public string NpaKind { get; set; }
   }
}