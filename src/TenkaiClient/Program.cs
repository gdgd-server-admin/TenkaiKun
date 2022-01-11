using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace TenkaiClient
{
    static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            logger.Info("起動");

            #region 多重起動を禁止する

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region 引数のチェックをする

            // 引数が1個あるか

            // 引数はファイルの絶対パスのはずなのでファイルが存在するか

            // ファイルの拡張子が展開くんのショートカットファイルか

            // 展開くんのショートカットファイルはテキストファイルなので読めるか

            // 展開くんのショートカットファイルはYaml形式のテキストなのでShortCutクラスでデシリアライズできるか

            // Urlのアドレスからレスポンスコード200が返ってくるか

            // Nameが空でないか

            // Pathが空でないか

            // これまでの処理がうまくいかなかった場合はメッセージを表示

            #endregion

            #region 更新があるか確認する

            // 更新ＵＲＬ、名称、起動パスが手に入っている場合のみ処理する

            // LiteDBから現在インストールされてるバージョンを取得

            // AutoUpdateにバージョン情報を同期モードで食わせる

            // アップデートを実行した場合はイベントハンドラ側でプログラムが終わるからこの下は処理されない

            #endregion

            #region プログラムを起動する

            // 更新ＵＲＬ、名称、起動パスが手に入っている場合のみ処理する

            // このプログラムの配置場所、名称、起動パスを使ってキックするプログラムの絶対パスを組み立てる

            // ファイルの存在を確認

            // ファイルが存在する場合は外部プロセス起動

            // ファイルが存在しない場合はメッセージを表示する

            #endregion

            // Application.Run(new Form1());

            logger.Info("終了");
        }
    }
}
