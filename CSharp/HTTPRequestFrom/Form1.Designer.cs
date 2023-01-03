namespace HTTPRequestFrom {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Files = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Language = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Chinese_China_Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.Eng_UK_Lang = new System.Windows.Forms.ToolStripMenuItem();
            this.HTTPUrl_Lable = new System.Windows.Forms.Label();
            this.HTTPUrl = new System.Windows.Forms.TextBox();
            this.Content_Type_Lable = new System.Windows.Forms.Label();
            this.Content_Type = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Files,
            this.ApplicationSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Files
            // 
            this.Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile});
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(44, 21);
            this.Files.Text = "文件";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(180, 22);
            this.OpenFile.Text = "打开文件";
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(180, 22);
            this.SaveFile.Text = "保存文件";
            // 
            // ApplicationSettings
            // 
            this.ApplicationSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings,
            this.Language,
            this.About});
            this.ApplicationSettings.Name = "ApplicationSettings";
            this.ApplicationSettings.Size = new System.Drawing.Size(44, 21);
            this.ApplicationSettings.Text = "应用";
            // 
            // Settings
            // 
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(180, 22);
            this.Settings.Text = "设置";
            // 
            // Language
            // 
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Chinese_China_Lang,
            this.Eng_UK_Lang});
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(180, 22);
            this.Language.Text = "语言";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(180, 22);
            this.About.Text = "关于";
            // 
            // Chinese_China_Lang
            // 
            this.Chinese_China_Lang.Name = "Chinese_China_Lang";
            this.Chinese_China_Lang.Size = new System.Drawing.Size(220, 22);
            this.Chinese_China_Lang.Text = "中文（中国）";
            // 
            // Eng_UK_Lang
            // 
            this.Eng_UK_Lang.Name = "Eng_UK_Lang";
            this.Eng_UK_Lang.Size = new System.Drawing.Size(220, 22);
            this.Eng_UK_Lang.Text = "English(United Kingdom)";
            this.Eng_UK_Lang.Click += new System.EventHandler(this.englishUnitedKingdomToolStripMenuItem_Click);
            // 
            // HTTPUrl_Lable
            // 
            this.HTTPUrl_Lable.AutoSize = true;
            this.HTTPUrl_Lable.Location = new System.Drawing.Point(35, 104);
            this.HTTPUrl_Lable.Name = "HTTPUrl_Lable";
            this.HTTPUrl_Lable.Size = new System.Drawing.Size(156, 17);
            this.HTTPUrl_Lable.TabIndex = 1;
            this.HTTPUrl_Lable.Text = "POST/GET地址(HTTP URL)";
            // 
            // HTTPUrl
            // 
            this.HTTPUrl.Location = new System.Drawing.Point(228, 101);
            this.HTTPUrl.Multiline = true;
            this.HTTPUrl.Name = "HTTPUrl";
            this.HTTPUrl.Size = new System.Drawing.Size(503, 23);
            this.HTTPUrl.TabIndex = 2;
            // 
            // Content_Type_Lable
            // 
            this.Content_Type_Lable.AutoSize = true;
            this.Content_Type_Lable.Location = new System.Drawing.Point(135, 136);
            this.Content_Type_Lable.Name = "Content_Type_Lable";
            this.Content_Type_Lable.Size = new System.Drawing.Size(56, 17);
            this.Content_Type_Lable.TabIndex = 3;
            this.Content_Type_Lable.Text = "数据类型";
            // 
            // Content_Type
            // 
            this.Content_Type.FormattingEnabled = true;
            this.Content_Type.Location = new System.Drawing.Point(228, 133);
            this.Content_Type.Name = "Content_Type";
            this.Content_Type.Size = new System.Drawing.Size(135, 25);
            this.Content_Type.TabIndex = 4;
            this.Content_Type.Text = "application/json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Content_Type);
            this.Controls.Add(this.Content_Type_Lable);
            this.Controls.Add(this.HTTPUrl);
            this.Controls.Add(this.HTTPUrl_Lable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Files;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem SaveFile;
        private ToolStripMenuItem ApplicationSettings;
        private ToolStripMenuItem Settings;
        private ToolStripMenuItem Language;
        private ToolStripMenuItem Chinese_China_Lang;
        private ToolStripMenuItem About;
        private ToolStripMenuItem Eng_UK_Lang;
        private Label HTTPUrl_Lable;
        private TextBox HTTPUrl;
        private Label Content_Type_Lable;
        private ComboBox Content_Type;
    }
}