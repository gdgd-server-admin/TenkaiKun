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
        [Route("metadata/{appname}")]
        public HttpResponseMessage GetData(string appname)
        {
            Tenkai tenkai = Tenkai.Find(appname);
            AutoUpdateXml xml = new AutoUpdateXml();
            xml.Url = $"http://{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/download/{tenkai.FileName}";
            xml.ChangeLog = $"http://{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/api/update/changelog/{appname}";
            xml.Version = tenkai.Version;
            xml.Mandatory = false;

            return new HttpResponseMessage()
            {
                Content = new StringContent(xml.ToString(), Encoding.UTF8, "text/xml")
            };
        }

        [HttpGet]
        [Route("changelog/{appname}")]
        public HttpResponseMessage GetChangelog(string appname)
        {
            Tenkai tenkai = Tenkai.Find(appname);
            

            return new HttpResponseMessage()
            {
                Content = new StringContent(tenkai.Changelog ?? "", Encoding.UTF8, "text/plain")
            };
        }
    }
}
