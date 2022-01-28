using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TenkaiLib.Models;

namespace TenkaiServer.WebAPI
{
    [RoutePrefix("api/update")]
    public class MetadataController : ApiController
    {
        [HttpGet]
        [Route("metadata/{oid}")]
        public HttpResponseMessage GetData(string oid)
        {
            Tenkai tenkai = Tenkai.FindByOid(oid);
            AutoUpdateXml xml = new AutoUpdateXml();
            xml.Url = $"http://{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/download/{tenkai.FileName}";
            xml.ChangeLog = $"http://{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/api/update/changelog/{tenkai.GetOid()}";
            xml.Version = tenkai.Version;
            xml.Mandatory = false;

            return new HttpResponseMessage()
            {
                Content = new StringContent(xml.ToString(), Encoding.UTF8, "text/xml")
            };
        }

        [HttpGet]
        [Route("changelog/{oid}")]
        public HttpResponseMessage GetChangelog(string oid)
        {
            Tenkai tenkai = Tenkai.FindByOid(oid);
            

            return new HttpResponseMessage()
            {
                Content = new StringContent(tenkai.Changelog ?? "", Encoding.UTF8, "text/plain")
            };
        }
    }
}
