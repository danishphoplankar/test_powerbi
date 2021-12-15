﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBIReportsApp.Models
{
    public interface IEmbedService
    {
        EmbedConfig EmbedConfig { get; }
        TileEmbedConfig TileEmbedConfig { get; }

        Task<bool> EmbedReport(string userName, string roles, string ReportId);
        Task<bool> EmbedDashboard();
        Task<bool> EmbedTile();
    }
}
