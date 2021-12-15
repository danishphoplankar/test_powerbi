using PowerBIReportsApp.Database;
using PowerBIReportsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PowerBIReportsApp.Controllers
{
    public class ReportsController : ApiController
    {
         [EnableCors(origins: "*", headers: "*", methods: "*")]
        public async System.Threading.Tasks.Task<PBIROutput> PowerBIDataAsync(PBIRInput input)
        {
            PBIROutput output = new PBIROutput();

            if (input.accessToken== "jECNFS4jQs")
            {
                PowerBIDBModel db = new PowerBIDBModel();

                var reportData = from o in db.AbpPowerBIReports
                                 where o.tenantId == input.tenantId && o.reportType == input.reportType
                                 select o.reportId;

                string ReportId = reportData.FirstOrDefault();

                if (ReportId.Length == 0 || ReportId == null || ReportId == "")
                {
                    output.embedToken = "";
                    output.embedUrl = "";
                    output.reportId = "";
                }
                else
                {
                    IEmbedService m_embedService;

                    m_embedService = new EmbedService();

                    EmbedConfig config;

                    var embedResult = await m_embedService.EmbedReport(null, null, ReportId);
                    if (embedResult)
                    {
                        config = m_embedService.EmbedConfig;
                    }
                    else
                    {
                        config = m_embedService.EmbedConfig;
                    }

                    output.embedToken = config.EmbedToken.Token;
                    output.embedUrl = config.EmbedUrl;
                    output.reportId = config.Id;
                }
            }
            else
            {
                output.embedToken = "";
                output.embedUrl = "";
                output.reportId = "";
            }
            
            return output;
        }
    }
}