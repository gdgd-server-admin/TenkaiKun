using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenkaiLib.Models
{
    public class AutoUpdateXml
    {
        public string Url { get; set; }
        public string ChangeLog { get; set; }
        public string Version { get; set; }
        public bool Mandatory { get; set; }

        /// <summary>
        /// AutoUpdate.NETが必要とするXMLに変換する
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sb.Append("<item>");
            sb.Append($"<version>{Version}</version>");
            sb.Append($"<url>{Url}</url>");

            if (!string.IsNullOrEmpty(ChangeLog))
            {
                sb.Append($"<changelog>{ChangeLog}</changelog>");
            }
            if (Mandatory)
            {
                sb.Append("<mandatory>true</mandatory>");
            }

            sb.Append("</item>");

            return sb.ToString();
        }
    }
}
