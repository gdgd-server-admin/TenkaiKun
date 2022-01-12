using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenkaiServer
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = Properties.Settings.Default;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("保存しました。反映するにはアプリケーションを再起動してください","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
