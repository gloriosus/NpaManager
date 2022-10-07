using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NpaManagerMVC.Models {
   public class NpaDbContext : DbContext{
      public DbSet<Period> Periods { get; set; }
      public DbSet<IogvRef> IogvRefs { get; set; }
      public DbSet<NpaKindsRef> NpaKinds { get; set; }
      public DbSet<NpaStatusRef> NpaStatus { get; set; }
      public DbSet<Deadline> Deadlines { get; set; }
      public DbSet<NpaI> NpaIS { get; set; }
      public DbSet<NpaII> NpaIIS { get; set; }
      public DbSet<NpaIII> NpaIIIS { get; set; }
      public DbSet<NpaIV> NpaIVS { get; set; }

      public NpaDbContext() :base("NpaDBConnection") {
         int count = NpaIVS.Count();
         var qqq = NpaIVS.ToList();
         Console.WriteLine(count);
      }

   }
}