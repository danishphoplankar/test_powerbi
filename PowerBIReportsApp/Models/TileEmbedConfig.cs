using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Microsoft.PowerBI.Api.Models;

namespace PowerBIReportsApp.Models
{
    public class TileEmbedConfig : EmbedConfig
    {
        public string dashboardId { get; set; }
    }
}