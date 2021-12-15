namespace PowerBIReportsApp.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PowerBIDBModel : DbContext
    {
        public PowerBIDBModel()
            : base("name=PowerBIDBModel")
        {
        }

        public virtual DbSet<AbpPowerBIReport> AbpPowerBIReports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
