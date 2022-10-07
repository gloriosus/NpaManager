using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   [Table("NpaStatusRef")]
   public class NpaStatusRef {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      [MaxLength(64)]
      [Display(Name = "Статус НПА")]
      public string Status { get; set; }

      [Display(Name = "Порядок сортировки")]
      public int StatusOrder { get; set; }
   }
}