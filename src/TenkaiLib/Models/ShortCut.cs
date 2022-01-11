using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenkaiLib.Models
{
    public class ShortCut
    {
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
    }
}
