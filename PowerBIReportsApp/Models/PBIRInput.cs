using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIReportsApp.Models
{
    public class PBIRInput
    {
        public int tenantId { get; set; }

        public string reportType { get; set; }

        public string accessToken { get; set; }
    }
}