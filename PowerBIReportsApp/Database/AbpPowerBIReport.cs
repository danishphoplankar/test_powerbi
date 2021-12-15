namespace PowerBIReportsApp.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AbpPowerBIReport
    {
        public int id { get; set; }

        public int? tenantId { get; set; }

        public int? userId { get; set; }

        public string reportId { get; set; }

        [StringLength(50)]
        public string reportType { get; set; }

        public bool? isActive { get; set; }

        public DateTime? insert_datetime { get; set; }

        [StringLength(50)]
        public string IP { get; set; }
    }
}
