using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using TenkaiLib.Models;
using System.IO;

namespace TenkaiServer
{
    static class Program
    {
        private const string STR_DEPLOY = "ファイルを展開";
        private const string STR_SETTING = "サーバ設定";
        private const string STR_MAKE_SHORTCUT = "ショートカット作成";

        private static Logger logger = LogManager.GetCurrentClassLogger();

        static Form origin;
        static IDisposable webapp;
        static NotifyIcon icon;
        static DeployForm deploy;
        static SettingForm setting;
        static ToolStripMenuItem tenkaimenu = new ToolStripMenuItem();

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
            menu.Items.Add(tenkaimenu);
            menu.Items.Add(STR_DEPLOY);
            menu.Items.Add(STR_SETTING);
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("終了");
            menu.ItemClicked += Menu_ItemClicked;
            icon.ContextMenuStrip = menu;

            tenkaimenu.Text = STR_MAKE_SHORTCUT;
            tenkaimenu.DropDownItemClicked += Tenkaimenu_DropDownItemClicked;
            UpdateTenkaiMenu();

            origin = new Form();

            try
            {
                var url = $"http://{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/";
                webapp = WebApp.Start<Startup>(url: url);
                menu.Items.Insert(0, new ToolStripSeparator());
                menu.Items.Insert(0, new ToolStripLabel($"{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}"));
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

        private static void Tenkaimenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            using(SaveFileDialog dialog = new SaveFileDialog())
            {
                var tenkai = Tenkai.Find(e.ClickedItem.Text);

                ShortCut shortCut = new ShortCut();
                shortCut.Name = tenkai.Name;
                shortCut.Url = $"http://{Properties.Settings.Default.待ち受けアドレス}:{Properties.Settings.Default.待ち受けポート}/api/update/metadata/{tenkai.Name}";
                shortCut.Path = tenkai.LaunchPath;

                dialog.Filter = "展開くんショートカット|*.ten";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    if (shortCut.SaveToFile(dialog.FileName))
                    {
                        MessageBox.Show("保存しました");
                    }
                    else
                    {
                        MessageBox.Show("保存に失敗しました。ログを確認してください");
                    }
                }
            }
            
        }

        private static void Deploy_Disposed(object sender, EventArgs e)
        {
            deploy = null;
            GC.Collect();
            deploy = new DeployForm();
            deploy.Disposed += Deploy_Disposed;

            UpdateTenkaiMenu();
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
                case STR_DEPLOY:
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
                case STR_SETTING:
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

        private static void UpdateTenkaiMenu()
        {
            tenkaimenu.DropDownItems.Clear();

            Tenkai.All().ForEach(x => tenkaimenu.DropDownItems.Add(x.Name));

        }
    }
}
