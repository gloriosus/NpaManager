using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   [Table("IogvRef")]
   /// <summary>
   /// Справочник органов власти
   /// </summary>
   public class IogvRef {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      [Display(Name ="Наименование органа власти")]
      [MaxLength(512)]
      public string Iogv { get; set; }
   }
}