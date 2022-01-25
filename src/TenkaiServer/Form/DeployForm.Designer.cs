
namespace TenkaiServer
{
    partial class DeployForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AppListPullDown = new System.Windows.Forms.ComboBox();
            this.VersionNoA = new System.Windows.Forms.NumericUpDown();
            this.VersionNoB = new System.Windows.Forms.NumericUpDown();
            this.VersionNoC = new System.Windows.Forms.NumericUpDown();
            this.VersionNoD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WithChangeLog = new System.Windows.Forms.CheckBox();
            this.ChangeLogTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ZipFilePath = new System.Windows.Forms.TextBox();
            this.FileChooseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.LaunchPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppListPullDown
            // 
            this.AppListPullDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AppListPullDown.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AppListPullDown.FormattingEnabled = true;
            this.AppListPullDown.Location = new System.Drawing.Point(203, 3);
            this.AppListPullDown.Name = "AppListPullDown";
            this.AppListPullDown.Size = new System.Drawing.Size(594, 23);
            this.AppListPullDown.TabIndex = 0;
            this.AppListPullDown.SelectedIndexChanged += new System.EventHandler(this.AppListPullDown_SelectedIndexChanged);
            // 
            // VersionNoA
            // 
            this.VersionNoA.Location = new System.Drawing.Point(3, 3);
            this.VersionNoA.Name = "VersionNoA";
            this.VersionNoA.Size = new System.Drawing.Size(43, 19);
            this.VersionNoA.TabIndex = 1;
            // 
            // VersionNoB
            // 
            this.VersionNoB.Location = new System.Drawing.Point(52, 3);
            this.VersionNoB.Name = "VersionNoB";
            this.VersionNoB.Size = new System.Drawing.Size(43, 19);
            this.VersionNoB.TabIndex = 2;
            // 
            // VersionNoC
            // 
            this.VersionNoC.Location = new System.Drawing.Point(101, 3);
            this.VersionNoC.Name = "VersionNoC";
            this.VersionNoC.Size = new System.Drawing.Size(43, 19);
            this.VersionNoC.TabIndex = 3;
            // 
            // VersionNoD
            // 
            this.VersionNoD.Location = new System.Drawing.Point(150, 3);
            this.VersionNoD.Name = "VersionNoD";
            this.VersionNoD.Size = new System.Drawing.Size(43, 19);
            this.VersionNoD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "バージョン";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "更新内容";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "名称";
            // 
            // WithChangeLog
            // 
            this.WithChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WithChangeLog.AutoSize = true;
            this.WithChangeLog.Location = new System.Drawing.Point(203, 127);
            this.WithChangeLog.Name = "WithChangeLog";
            this.WithChangeLog.Size = new System.Drawing.Size(594, 16);
            this.WithChangeLog.TabIndex = 8;
            this.WithChangeLog.Text = "更新内容を知らせる";
            this.WithChangeLog.UseVisualStyleBackColor = true;
            // 
            // ChangeLogTextBox
            // 
            this.ChangeLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeLogTextBox.Location = new System.Drawing.Point(203, 153);
            this.ChangeLogTextBox.Name = "ChangeLogTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.ChangeLogTextBox, 2);
            this.ChangeLogTextBox.Size = new System.Drawing.Size(594, 110);
            this.ChangeLogTextBox.TabIndex = 9;
            this.ChangeLogTextBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ChangeLogTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AppListPullDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.WithChangeLog, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LaunchPath, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 236);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.VersionNoA);
            this.flowLayoutPanel1.Controls.Add(this.VersionNoB);
            this.flowLayoutPanel1.Controls.Add(this.VersionNoC);
            this.flowLayoutPanel1.Controls.Add(this.VersionNoD);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 24);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "ZIPファイル";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ZipFilePath);
            this.panel2.Controls.Add(this.FileChooseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 24);
            this.panel2.TabIndex = 12;
            // 
            // ZipFilePath
            // 
            this.ZipFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipFilePath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ZipFilePath.Location = new System.Drawing.Point(0, 0);
            this.ZipFilePath.Name = "ZipFilePath";
            this.ZipFilePath.ReadOnly = true;
            this.ZipFilePath.Size = new System.Drawing.Size(554, 22);
            this.ZipFilePath.TabIndex = 1;
            // 
            // FileChooseButton
            // 
            this.FileChooseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileChooseButton.Location = new System.Drawing.Point(554, 0);
            this.FileChooseButton.Name = "FileChooseButton";
            this.FileChooseButton.Size = new System.Drawing.Size(40, 24);
            this.FileChooseButton.TabIndex = 0;
            this.FileChooseButton.Text = "参照";
            this.FileChooseButton.UseVisualStyleBackColor = true;
            this.FileChooseButton.Click += new System.EventHandler(this.FileChooseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveButton.Location = new System.Drawing.Point(681, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 46);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "展　開";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "ZIPファイル|*.zip|インストーラー|*.exe";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "起動パス";
            // 
            // LaunchPath
            // 
            this.LaunchPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LaunchPath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LaunchPath.Location = new System.Drawing.Point(203, 63);
            this.LaunchPath.Name = "LaunchPath";
            this.LaunchPath.Size = new System.Drawing.Size(594, 22);
            this.LaunchPath.TabIndex = 14;
            // 
            // DeployForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "DeployForm";
            this.Text = "ファイルを展開する";
            this.Load += new System.EventHandler(this.DeployForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AppListPullDown;
        private System.Windows.Forms.NumericUpDown VersionNoA;
        private System.Windows.Forms.NumericUpDown VersionNoB;
        private System.Windows.Forms.NumericUpDown VersionNoC;
        private System.Windows.Forms.NumericUpDown VersionNoD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox WithChangeLog;
        private System.Windows.Forms.RichTextBox ChangeLogTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ZipFilePath;
        private System.Windows.Forms.Button FileChooseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LaunchPath;
    }
}