using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIReportsApp.Models
{
    public class PBIROutput
    {
        public string embedToken { get; set; }

        public string embedUrl { get; set; }

        public string reportId { get; set; }
    }
}