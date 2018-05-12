namespace YouTubeDL
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_AllComp = new System.Windows.Forms.Panel();
            this.pictureBox_More = new System.Windows.Forms.PictureBox();
            this.pictureBox_Loading = new System.Windows.Forms.PictureBox();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.textBox_XFormat = new System.Windows.Forms.TextBox();
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.button_FindRes = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_Download = new System.Windows.Forms.Button();
            this.radioButton_XFormat = new System.Windows.Forms.RadioButton();
            this.radioButton_Audio = new System.Windows.Forms.RadioButton();
            this.radioButton_Video = new System.Windows.Forms.RadioButton();
            this.checkBox_List = new System.Windows.Forms.CheckBox();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.timer_Res = new System.Windows.Forms.Timer(this.components);
            this.timer_Update = new System.Windows.Forms.Timer(this.components);
            this.panel_AllComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_More)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AllComp
            // 
            this.panel_AllComp.Controls.Add(this.pictureBox_More);
            this.panel_AllComp.Controls.Add(this.pictureBox_Loading);
            this.panel_AllComp.Controls.Add(this.textBox_Info);
            this.panel_AllComp.Controls.Add(this.textBox_XFormat);
            this.panel_AllComp.Controls.Add(this.pictureBox_Clear);
            this.panel_AllComp.Controls.Add(this.button_FindRes);
            this.panel_AllComp.Controls.Add(this.pictureBox_Logo);
            this.panel_AllComp.Controls.Add(this.button_Download);
            this.panel_AllComp.Controls.Add(this.radioButton_XFormat);
            this.panel_AllComp.Controls.Add(this.radioButton_Audio);
            this.panel_AllComp.Controls.Add(this.radioButton_Video);
            this.panel_AllComp.Controls.Add(this.checkBox_List);
            this.panel_AllComp.Controls.Add(this.textBox_URL);
            this.panel_AllComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AllComp.Location = new System.Drawing.Point(0, 0);
            this.panel_AllComp.Name = "panel_AllComp";
            this.panel_AllComp.Size = new System.Drawing.Size(636, 561);
            this.panel_AllComp.TabIndex = 0;
            // 
            // pictureBox_More
            // 
            this.pictureBox_More.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBox_More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_More.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_More.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_More.Image")));
            this.pictureBox_More.Location = new System.Drawing.Point(0, 553);
            this.pictureBox_More.Name = "pictureBox_More";
            this.pictureBox_More.Size = new System.Drawing.Size(636, 8);
            this.pictureBox_More.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_More.TabIndex = 11;
            this.pictureBox_More.TabStop = false;
            this.pictureBox_More.Click += new System.EventHandler(this.pictureBox_More_Click);
            // 
            // pictureBox_Loading
            // 
            this.pictureBox_Loading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Loading.Image")));
            this.pictureBox_Loading.Location = new System.Drawing.Point(3, 104);
            this.pictureBox_Loading.Name = "pictureBox_Loading";
            this.pictureBox_Loading.Size = new System.Drawing.Size(630, 443);
            this.pictureBox_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Loading.TabIndex = 13;
            this.pictureBox_Loading.TabStop = false;
            this.pictureBox_Loading.Visible = false;
            // 
            // textBox_Info
            // 
            this.textBox_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.textBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Info.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_Info.ForeColor = System.Drawing.Color.White;
            this.textBox_Info.Location = new System.Drawing.Point(12, 104);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.ReadOnly = true;
            this.textBox_Info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Info.Size = new System.Drawing.Size(621, 443);
            this.textBox_Info.TabIndex = 12;
            this.textBox_Info.TabStop = false;
            // 
            // textBox_XFormat
            // 
            this.textBox_XFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBox_XFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_XFormat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_XFormat.ForeColor = System.Drawing.Color.White;
            this.textBox_XFormat.Location = new System.Drawing.Point(244, 76);
            this.textBox_XFormat.Name = "textBox_XFormat";
            this.textBox_XFormat.Size = new System.Drawing.Size(221, 22);
            this.textBox_XFormat.TabIndex = 9;
            this.textBox_XFormat.TabStop = false;
            this.textBox_XFormat.Visible = false;
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Clear.Image")));
            this.pictureBox_Clear.Location = new System.Drawing.Point(606, 50);
            this.pictureBox_Clear.Name = "pictureBox_Clear";
            this.pictureBox_Clear.Size = new System.Drawing.Size(18, 18);
            this.pictureBox_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Clear.TabIndex = 8;
            this.pictureBox_Clear.TabStop = false;
            this.pictureBox_Clear.Click += new System.EventHandler(this.pictureBox_Clear_Click);
            // 
            // button_FindRes
            // 
            this.button_FindRes.FlatAppearance.BorderSize = 0;
            this.button_FindRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FindRes.ForeColor = System.Drawing.Color.Red;
            this.button_FindRes.Location = new System.Drawing.Point(471, 74);
            this.button_FindRes.Name = "button_FindRes";
            this.button_FindRes.Size = new System.Drawing.Size(51, 24);
            this.button_FindRes.TabIndex = 7;
            this.button_FindRes.TabStop = false;
            this.button_FindRes.Text = "Find";
            this.button_FindRes.UseVisualStyleBackColor = true;
            this.button_FindRes.Click += new System.EventHandler(this.button_FindRes_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::YouTubeDL.Properties.Resources.yt;
            this.pictureBox_Logo.Location = new System.Drawing.Point(12, 3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(162, 41);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 6;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.DoubleClick += new System.EventHandler(this.pictureBox_Logo_DoubleClick);
            // 
            // button_Download
            // 
            this.button_Download.FlatAppearance.BorderSize = 0;
            this.button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Download.ForeColor = System.Drawing.Color.Red;
            this.button_Download.Location = new System.Drawing.Point(528, 74);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(96, 24);
            this.button_Download.TabIndex = 5;
            this.button_Download.TabStop = false;
            this.button_Download.Text = "Download";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // radioButton_XFormat
            // 
            this.radioButton_XFormat.AutoSize = true;
            this.radioButton_XFormat.ForeColor = System.Drawing.Color.White;
            this.radioButton_XFormat.Location = new System.Drawing.Point(226, 74);
            this.radioButton_XFormat.Name = "radioButton_XFormat";
            this.radioButton_XFormat.Size = new System.Drawing.Size(95, 24);
            this.radioButton_XFormat.TabIndex = 4;
            this.radioButton_XFormat.Text = "X Format";
            this.radioButton_XFormat.UseVisualStyleBackColor = true;
            this.radioButton_XFormat.CheckedChanged += new System.EventHandler(this.radioButton_XFormat_CheckedChanged);
            // 
            // radioButton_Audio
            // 
            this.radioButton_Audio.AutoSize = true;
            this.radioButton_Audio.ForeColor = System.Drawing.Color.White;
            this.radioButton_Audio.Location = new System.Drawing.Point(148, 74);
            this.radioButton_Audio.Name = "radioButton_Audio";
            this.radioButton_Audio.Size = new System.Drawing.Size(72, 24);
            this.radioButton_Audio.TabIndex = 3;
            this.radioButton_Audio.Text = "Audio";
            this.radioButton_Audio.UseVisualStyleBackColor = true;
            this.radioButton_Audio.CheckedChanged += new System.EventHandler(this.radioButton_Audio_CheckedChanged);
            // 
            // radioButton_Video
            // 
            this.radioButton_Video.AutoSize = true;
            this.radioButton_Video.Checked = true;
            this.radioButton_Video.ForeColor = System.Drawing.Color.White;
            this.radioButton_Video.Location = new System.Drawing.Point(71, 74);
            this.radioButton_Video.Name = "radioButton_Video";
            this.radioButton_Video.Size = new System.Drawing.Size(71, 24);
            this.radioButton_Video.TabIndex = 2;
            this.radioButton_Video.TabStop = true;
            this.radioButton_Video.Text = "Video";
            this.radioButton_Video.UseVisualStyleBackColor = true;
            this.radioButton_Video.CheckedChanged += new System.EventHandler(this.radioButton_Video_CheckedChanged);
            // 
            // checkBox_List
            // 
            this.checkBox_List.AutoSize = true;
            this.checkBox_List.ForeColor = System.Drawing.Color.White;
            this.checkBox_List.Location = new System.Drawing.Point(12, 74);
            this.checkBox_List.Name = "checkBox_List";
            this.checkBox_List.Size = new System.Drawing.Size(53, 24);
            this.checkBox_List.TabIndex = 1;
            this.checkBox_List.TabStop = false;
            this.checkBox_List.Text = "List";
            this.checkBox_List.UseVisualStyleBackColor = true;
            // 
            // textBox_URL
            // 
            this.textBox_URL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBox_URL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_URL.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_URL.ForeColor = System.Drawing.Color.White;
            this.textBox_URL.Location = new System.Drawing.Point(12, 50);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(588, 18);
            this.textBox_URL.TabIndex = 0;
            this.textBox_URL.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox_URL_MouseDoubleClick);
            // 
            // timer_Res
            // 
            this.timer_Res.Tick += new System.EventHandler(this.timer_Res_Tick);
            // 
            // timer_Update
            // 
            this.timer_Update.Tick += new System.EventHandler(this.timer_Update_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(636, 561);
            this.Controls.Add(this.panel_AllComp);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Downloader";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_AllComp.ResumeLayout(false);
            this.panel_AllComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_More)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AllComp;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.RadioButton radioButton_Video;
        private System.Windows.Forms.CheckBox checkBox_List;
        private System.Windows.Forms.RadioButton radioButton_XFormat;
        private System.Windows.Forms.RadioButton radioButton_Audio;
        private System.Windows.Forms.Button button_FindRes;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.TextBox textBox_XFormat;
        private System.Windows.Forms.PictureBox pictureBox_More;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.Timer timer_Res;
        private System.Windows.Forms.PictureBox pictureBox_Loading;
        private System.Windows.Forms.Timer timer_Update;
    }
}

