using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using NLog;
using TenkaiLib.Models;

namespace TenkaiClient
{
    static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static string newversion = "";
        private static string appname = "";
        private static string executepath = "";
        private static bool updated = false;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            logger.Info("起動");

            #region 多重起動を禁止する

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ShortCut shortcut = null;

            #region 引数のチェックをする

            // 引数が1個あるか
            if (args.Length != 1)
            {
                logger.Debug("引数が1個ではない");
                return;
            }

            var shortcut_path = args.First();

            // 引数はファイルの絶対パスのはずなのでファイルが存在するか
            if (!File.Exists(shortcut_path))
            {
                logger.Debug("与えられた引数をファイルのパスとした時にファイルが存在しない");
                return;
            }

            // ファイルの拡張子が展開くんのショートカットファイルか
            if(Path.GetExtension(shortcut_path) != ".ten")
            {
                logger.Debug("ファイルは存在するが展開くんショートカットではなさそう");
                return;
            }

            try
            {
                // 展開くんのショートカットファイルはテキストファイルなので読めるか
                // 展開くんのショートカットファイルはYaml形式のテキストなのでShortCutクラスでデシリアライズできるか
                shortcut = ShortCut.ReadFromFile(shortcut_path);
                appname = shortcut.Name;
                executepath = shortcut.Path;
           
                // Urlのアドレスからレスポンスコード200が返ってくるか
                // Nameが空でないか
                // Pathが空でないか
                if (!shortcut.Validate())
                {
                    logger.Debug("検証の結果起動できないと判断した");
                    return;
                }
            }
            catch
            {
                logger.Debug("ファイルの中身が読み込めない");
                return;
            }

            #endregion

            #region 更新があるか確認する

            // 更新ＵＲＬ、名称、起動パスが手に入っている場合のみ処理する

            // LiteDBから現在インストールされてるバージョンを取得

            // AutoUpdateにバージョン情報を同期モードで食わせる
            Tenkai tenkai = Tenkai.FindByName(appname);
            AutoUpdater.InstalledVersion = new Version(tenkai.Version);
            AutoUpdater.InstallationPath = Path.Combine(Application.StartupPath, shortcut.Name);
            if (!Directory.Exists(Path.Combine(Application.StartupPath, shortcut.Name))) Directory.CreateDirectory(Path.Combine(Application.StartupPath, shortcut.Name));
            AutoUpdater.Mandatory = true;
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Synchronous = true;
            AutoUpdater.CheckForUpdateEvent += AutoUpdater_CheckForUpdateEvent;
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            AutoUpdater.Start(shortcut.Url);

            // アップデートを実行した場合はイベントハンドラ側でプログラムが終わるからこの下は処理されない

            #endregion

            
            // Application.Run(new Form1());

            logger.Info("終了");
        }

        private static void AutoUpdater_ApplicationExitEvent()
        {
            if (!string.IsNullOrWhiteSpace(newversion))
            {
                Tenkai tenkai = Tenkai.FindByName(appname);
                tenkai.Version = newversion;
                tenkai.Name = appname;
                tenkai.Save();
                updated = true;
            }
        }

        private static void AutoUpdater_CheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                newversion = args.CurrentVersion;

                AutoUpdater.ShowUpdateForm(args);

                if (!updated)
                {
                    newversion = "";

                    // 素直にアップデートしてればここまで来ない
                    MessageBox.Show("更新してないので起動を許可しない", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
               

            }
            else
            {
                #region プログラムを起動する

                // 更新ＵＲＬ、名称、起動パスが手に入っている場合のみ処理する

                // このプログラムの配置場所、名称、起動パスを使ってキックするプログラムの絶対パスを組み立てる
                var launchpath = Path.Combine(Application.StartupPath, appname, executepath);

                // ファイルの存在を確認
                if (!File.Exists(launchpath))
                {
                    logger.Debug("アップデートは出来ているが起動できるものがない");
                    return;
                }

                // ファイルが存在する場合は外部プロセス起動
                Process.Start(launchpath);

                #endregion

            }
        }
    }
}
