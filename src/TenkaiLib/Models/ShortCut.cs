using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace TenkaiLib.Models
{
    public class ShortCut
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
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
    }
}
