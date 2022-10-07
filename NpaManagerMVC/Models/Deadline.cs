using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   [Table("Deadlines")]
   public class Deadline {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      [MaxLength(128)]
      public string PeriodId { get; set; }

      [Display(Name = "орг. отдел I")]
      public int DeadlineOrgI { get; set; }

      [Display(Name = "лингв экспетиза I")]
      public int DeadlineLingvI { get; set; }

      [Display(Name = "экономисты I")]
      public int DeadlineEconI { get; set; }

      [Display(Name = "юр. экспертиза I")]
      public int DeadlineLawI { get; set; }

      [Display(Name = "зак собрание II")]
      public int DeadlineAssemblyII { get; set; }

      [Display(Name = "иные II")]
      public int DeadlineOtherII { get; set; }

      [Display(Name = "юр. экспертиза II")]
      public int DeadlineLawII { get; set; }

      [Display(Name = "лингв. экспертиза III")]
      public int DeadlineLingvIII { get; set; }

      [Display(Name = "юр. экспертиза III")]
      public int DeadlineLawIII { get; set; }

      [Display(Name = "юр. экспертиза IV")]
      public int DeadlineLawIV { get; set; }
   }
}