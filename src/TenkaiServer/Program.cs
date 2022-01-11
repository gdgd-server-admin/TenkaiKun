using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenkaiServer
{
    static class Program
    {

        static Form origin;
        static IDisposable webapp;
        static NotifyIcon icon;
        static DeployForm deploy;
        static SettingForm setting;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 多重起動を禁止する

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            icon = new NotifyIcon();
            icon.Icon = SystemIcons.Application;
            icon.Visible = true;
            icon.Text = "展開くんサーバ";
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("ファイルを展開");
            menu.Items.Add("サーバ設定");
            menu.Items.Add("終了");
            menu.ItemClicked += Menu_ItemClicked;
            icon.ContextMenuStrip = menu;

            origin = new Form();

            try
            {
                webapp = WebApp.Start<Startup>(url: $"http://127.0.0.1:24680/");
            }
            catch
            {
                MessageBox.Show("APIサーバの起動に失敗。設定を確認してアプリケーションを再起動してください");
            }

            setting = new SettingForm();
            setting.Disposed += Setting_Disposed;
            deploy = new DeployForm();
            deploy.Disposed += Deploy_Disposed;

            Application.Run();
        }

        private static void Deploy_Disposed(object sender, EventArgs e)
        {
            deploy = null;
            GC.Collect();
            deploy = new DeployForm();
            deploy.Disposed += Deploy_Disposed;
        }

        private static void Setting_Disposed(object sender, EventArgs e)
        {
            setting = null;
            GC.Collect();
            setting = new SettingForm();
            setting.Disposed += Setting_Disposed;
        }

        private static void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "ファイルを展開":
                    try
                    {
                        deploy.Show(origin);
                    }
                    catch
                    {
                        deploy.Activate();
                    }
                    break;
                case "サーバ設定":
                    try
                    {
                        setting.Show(origin);
                    }
                    catch
                    {
                        setting.Activate();
                    }
                    break;
                case "終了":
                    icon.Visible = false;
                    icon.Dispose();
                    Application.Exit();
                    break;
            }
        }
    }
}
