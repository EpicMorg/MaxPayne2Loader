namespace max_payne2_loader
{
    partial class frm_Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pic_logo_main = new System.Windows.Forms.PictureBox();
            this.chbx_developerkeys = new System.Windows.Forms.CheckBox();
            this.btn_rungame = new System.Windows.Forms.Button();
            this.btn_howtouse = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.chbx_screenshots = new System.Windows.Forms.CheckBox();
            this.chbx_developer = new System.Windows.Forms.CheckBox();
            this.ofdpain2 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo_main
            // 
            this.pic_logo_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_logo_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_logo_main.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo_main.Image")));
            this.pic_logo_main.Location = new System.Drawing.Point(12, 12);
            this.pic_logo_main.Name = "pic_logo_main";
            this.pic_logo_main.Size = new System.Drawing.Size(148, 259);
            this.pic_logo_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo_main.TabIndex = 0;
            this.pic_logo_main.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_logo_main, "Перейти на офф. сайт игры.");
            this.pic_logo_main.Click += new System.EventHandler(this.pic_logo_main_Click);
            // 
            // chbx_developerkeys
            // 
            this.chbx_developerkeys.AutoSize = true;
            this.chbx_developerkeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_developerkeys.Location = new System.Drawing.Point(12, 303);
            this.chbx_developerkeys.Name = "chbx_developerkeys";
            this.chbx_developerkeys.Size = new System.Drawing.Size(95, 17);
            this.chbx_developerkeys.TabIndex = 1;
            this.chbx_developerkeys.Text = "-developerkeys";
            this.toolTip1.SetToolTip(this.chbx_developerkeys, "Позволяет задействовать клавиши разработчиков. Например, клавиша для смены модель" +
        "ки игрока.");
            this.chbx_developerkeys.UseVisualStyleBackColor = true;
            // 
            // btn_rungame
            // 
            this.btn_rungame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rungame.Location = new System.Drawing.Point(12, 277);
            this.btn_rungame.Name = "btn_rungame";
            this.btn_rungame.Size = new System.Drawing.Size(44, 23);
            this.btn_rungame.TabIndex = 2;
            this.btn_rungame.Text = "Run!";
            this.toolTip1.SetToolTip(this.btn_rungame, "Запуск игры с выбранными параметрами.");
            this.btn_rungame.UseVisualStyleBackColor = true;
            this.btn_rungame.Click += new System.EventHandler(this.btn_rungame_Click);
            // 
            // btn_howtouse
            // 
            this.btn_howtouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_howtouse.Location = new System.Drawing.Point(62, 277);
            this.btn_howtouse.Name = "btn_howtouse";
            this.btn_howtouse.Size = new System.Drawing.Size(45, 23);
            this.btn_howtouse.TabIndex = 3;
            this.btn_howtouse.TabStop = false;
            this.btn_howtouse.Text = "Help!";
            this.toolTip1.SetToolTip(this.btn_howtouse, "Помощь в использовании.");
            this.btn_howtouse.UseVisualStyleBackColor = true;
            this.btn_howtouse.Click += new System.EventHandler(this.btn_howtouse_Click);
            // 
            // btn_info
            // 
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.Location = new System.Drawing.Point(113, 277);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(47, 23);
            this.btn_info.TabIndex = 4;
            this.btn_info.TabStop = false;
            this.btn_info.Text = "Info!";
            this.toolTip1.SetToolTip(this.btn_info, "О программе.");
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // chbx_screenshots
            // 
            this.chbx_screenshots.AutoSize = true;
            this.chbx_screenshots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_screenshots.Location = new System.Drawing.Point(88, 326);
            this.chbx_screenshots.Name = "chbx_screenshots";
            this.chbx_screenshots.Size = new System.Drawing.Size(83, 17);
            this.chbx_screenshots.TabIndex = 5;
            this.chbx_screenshots.Text = "-screenshots";
            this.toolTip1.SetToolTip(this.chbx_screenshots, "Позволяет делать скриншоты во время игры при нажатии на спец. клавишу.");
            this.chbx_screenshots.UseVisualStyleBackColor = true;
            // 
            // chbx_developer
            // 
            this.chbx_developer.AutoSize = true;
            this.chbx_developer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbx_developer.Location = new System.Drawing.Point(12, 326);
            this.chbx_developer.Name = "chbx_developer";
            this.chbx_developer.Size = new System.Drawing.Size(73, 17);
            this.chbx_developer.TabIndex = 6;
            this.chbx_developer.Text = "-developer";
            this.toolTip1.SetToolTip(this.chbx_developer, "Включение режима разработчика. Также позволяет задействовать игровую консоль.");
            this.chbx_developer.UseVisualStyleBackColor = true;
            // 
            // ofdpain2
            // 
            this.ofdpain2.FileName = "MaxPayne2.exe";
            this.ofdpain2.Filter = "Max Payne 2 Game main file|MaxPayne2.exe";
            this.ofdpain2.Title = ".:[Max Payne 2 :: Browse]:.";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 355);
            this.Controls.Add(this.chbx_developer);
            this.Controls.Add(this.chbx_screenshots);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_howtouse);
            this.Controls.Add(this.btn_rungame);
            this.Controls.Add(this.chbx_developerkeys);
            this.Controls.Add(this.pic_logo_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Max Payne 2™ Loader";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo_main;
        private System.Windows.Forms.CheckBox chbx_developerkeys;
        private System.Windows.Forms.Button btn_rungame;
        private System.Windows.Forms.Button btn_howtouse;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.CheckBox chbx_screenshots;
        private System.Windows.Forms.CheckBox chbx_developer;
        private System.Windows.Forms.OpenFileDialog ofdpain2;
        private System.Windows.Forms.ToolTip toolTip1;



    }
}

