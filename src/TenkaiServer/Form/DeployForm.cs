using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NLog;
using TenkaiLib.Models;

namespace TenkaiServer
{
    public partial class DeployForm : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public DeployForm()
        {
            InitializeComponent();
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ZipFilePath.Text = openFileDialog1.FileName;
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppListPullDown.Text))
            {
                MessageBox.Show("名称を入力してください");
                return;
            }

            if (string.IsNullOrWhiteSpace(ZipFilePath.Text))
            {
                MessageBox.Show("展開するファイルを選択してください");
                return;
            }

            tableLayoutPanel1.Enabled = false;
            panel1.Enabled = false;
            UseWaitCursor = true;

            string _name = AppListPullDown.Text;
            string _filename = $"{_name}_{ZipFilePath.Text.Split('\\').Last()}";
            string _fullpath = ZipFilePath.Text;
            string _version = $"{VersionNoA.Value}.{VersionNoB.Value}.{VersionNoC.Value}.{VersionNoD.Value}";
            string _changelog = WithChangeLog.Checked ? ChangeLogTextBox.Text : "";

            var result = await Task.Run(() =>
            {
                try
                {
                    Tenkai tenkai = Tenkai.Find(_name);
                    tenkai.FileName = _filename;
                    tenkai.Version = _version;
                    tenkai.Changelog = _changelog;
                    tenkai.Save();

                    return true;
                }
                catch(Exception ex)
                {
                    logger.Error(ex, "");
                    return false;
                }

            });


            UseWaitCursor = false;
            MessageBox.Show("データを保存しました");
            tableLayoutPanel1.Enabled = true;
            panel1.Enabled = true;
        }

        private void DeployForm_Load(object sender, EventArgs e)
        {
            AppListPullDown.Items.Add("test");
        }
    }
}
