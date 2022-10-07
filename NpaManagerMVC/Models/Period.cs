using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   [Table("Periods")]
   public class Period {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      //[ForeignKey("TProject")]
      [MaxLength(128)]
      public string PeriodId { get; set; }

      [Display(Name = "Год")]
      public int Year { get; set; }

      [Display(Name = "Квартал")]
      public int Quarter { get; set; }

      [Display(Name = "С")]
      public DateTime DateFirst { get; set; }

      [Display(Name = "По")]
      public DateTime DateEnd { get; set; }

      [Display(Name = "Правка")]
      public bool Editable { get; set; }

      [Display(Name = "На сайт")]
      public bool Browsable { get; set; }
   }
}