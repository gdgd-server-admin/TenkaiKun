using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace TenkaiLib.Models
{
    public class ShortCut
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// LiteDBのObjectIdを文字列にして入れておく
        /// </summary>
        public string Oid { get; set; }

        /// <summary>
        /// サーバＵＲＬ
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 名称。フォルダ名とデータベースのキーにする
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 起動パス。保存したフォルダをルートとした相対パス
        /// </summary>
        public string Path { get; set; }

        public bool SaveToFile(string filepath)
        {
            bool res = false;

            try
            {
                using (TextWriter writer = File.CreateText(filepath))
                {
                    var serializer = new Serializer();
                    serializer.Serialize(writer, this);
                    res = true;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex, "ショートカットファイル作成中にエラー");
            }

            return res;
        }

        public static ShortCut ReadFromFile(string filepath)
        {
            using (var input = new StreamReader(filepath, Encoding.UTF8))
            {
                var deserializer = new Deserializer();
                var res = deserializer.Deserialize<ShortCut>(input);

                return res;
            }
        }

        public bool Validate()
        {
            bool res = true;

            // Urlのアドレスからレスポンスコード200が返ってくるか
            using (var client = new HttpClient())
            {
                var result = client.GetAsync(Url).Result;
                if (result.StatusCode != System.Net.HttpStatusCode.OK) res = false;
            }

            // Nameが空でないか
            if (string.IsNullOrWhiteSpace(Name)) res = false;

            // Pathが空でないか
            if (string.IsNullOrWhiteSpace(Path)) res = false;

            return res;
        }
    }
}
