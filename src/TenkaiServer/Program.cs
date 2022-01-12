using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace TenkaiServer
{
    static class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

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
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("終了");
            menu.ItemClicked += Menu_ItemClicked;
            icon.ContextMenuStrip = menu;

            origin = new Form();

            try
            {
                var url = $"http://{Properties.Settings.Default.I待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/";
                webapp = WebApp.Start<Startup>(url: url);
                menu.Items.Insert(0, new ToolStripSeparator());
                menu.Items.Insert(0, new ToolStripLabel($"{Properties.Settings.Default.I待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}"));
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
                        if (deploy.Visible)
                        {
                            deploy.Activate();
                        }
                        else
                        {
                            deploy.Show(origin);
                        }
                    }
                    catch(Exception ex)
                    {
                        logger.Error(ex, "");
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "サーバ設定":
                    try
                    {
                        if (setting.Visible)
                        {
                            setting.Activate();
                        }
                        else
                        {
                            setting.Show(origin);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex, "");
                        MessageBox.Show(ex.Message);
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
