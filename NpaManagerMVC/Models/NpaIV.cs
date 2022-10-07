using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   [Table("NpaIV")]
   public class NpaIV {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
      public int Id { get; set; }

      [MaxLength(128)]
      [Display(Name ="Период")]
      public string PeriodId { get; set; }

      [Display(Name = "Номер")]
      public decimal Index { get; set; }

      [Display(Name = "Состояние")]
      public string NpaState { get; set; }

      [Display(Name = "Наименование НПА")]
      public string Npaname { get; set; }

      [Display(Name = "")]
      public string Iogv { get; set; }

      [Display(Name = "Юр эксп")]
      public DateTime? PlanDateLaw { get; set; }

      [Display(Name = "Юр регистрация")]
      public DateTime? RegDateLaw { get; set; }

      [Display(Name = "Примечание")]
      public string NpaNote { get; set; }

      [Display(Name = "Статус")]
      public string Status { get; set; }
   }
}