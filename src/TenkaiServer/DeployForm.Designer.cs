
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FileChooseButton = new System.Windows.Forms.Button();
            this.ZipFilePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoD)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppListPullDown
            // 
            this.AppListPullDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AppListPullDown.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AppListPullDown.FormattingEnabled = true;
            this.AppListPullDown.Location = new System.Drawing.Point(203, 5);
            this.AppListPullDown.Name = "AppListPullDown";
            this.AppListPullDown.Size = new System.Drawing.Size(594, 23);
            this.AppListPullDown.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "バージョン";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 99);
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
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(594, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "更新内容を知らせる";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(203, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox1, 2);
            this.richTextBox1.Size = new System.Drawing.Size(594, 118);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AppListPullDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(203, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 24);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 11;
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
            // FileChooseButton
            // 
            this.FileChooseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileChooseButton.Location = new System.Drawing.Point(554, 0);
            this.FileChooseButton.Name = "FileChooseButton";
            this.FileChooseButton.Size = new System.Drawing.Size(40, 24);
            this.FileChooseButton.TabIndex = 0;
            this.FileChooseButton.Text = "参照";
            this.FileChooseButton.UseVisualStyleBackColor = true;
            // 
            // ZipFilePath
            // 
            this.ZipFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZipFilePath.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ZipFilePath.Location = new System.Drawing.Point(0, 0);
            this.ZipFilePath.Name = "ZipFilePath";
            this.ZipFilePath.Size = new System.Drawing.Size(554, 22);
            this.ZipFilePath.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(681, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "展　開";
            this.button2.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionNoD)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ZipFilePath;
        private System.Windows.Forms.Button FileChooseButton;
        private System.Windows.Forms.Button button2;
    }
}