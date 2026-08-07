namespace oembuild
{
    partial class Form1
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
            this.pc_name_lbl = new System.Windows.Forms.Label();
            this.pc_name_tb = new System.Windows.Forms.TextBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.save_cfg_btn = new System.Windows.Forms.Button();
            this.reb_pc_cb = new System.Windows.Forms.CheckBox();
            this.company_name_lbl = new System.Windows.Forms.Label();
            this.company_name_tb = new System.Windows.Forms.TextBox();
            this.model_name_tb = new System.Windows.Forms.TextBox();
            this.model_name_lbl = new System.Windows.Forms.Label();
            this.suphours_tb = new System.Windows.Forms.TextBox();
            this.suphours_lbl = new System.Windows.Forms.Label();
            this.supphone_tb = new System.Windows.Forms.TextBox();
            this.supphone_lbl = new System.Windows.Forms.Label();
            this.supurl_tb = new System.Windows.Forms.TextBox();
            this.supurl_lbl = new System.Windows.Forms.Label();
            this.logo_tb = new System.Windows.Forms.TextBox();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fd_btn = new System.Windows.Forms.Button();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.load_cfg_btn = new System.Windows.Forms.Button();
            this.show_info_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.wallpaper_lbl = new System.Windows.Forms.Label();
            this.wallpaper_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wallpaper_pb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_name_lbl
            // 
            this.pc_name_lbl.AutoSize = true;
            this.pc_name_lbl.Location = new System.Drawing.Point(9, 14);
            this.pc_name_lbl.Name = "pc_name_lbl";
            this.pc_name_lbl.Size = new System.Drawing.Size(47, 13);
            this.pc_name_lbl.TabIndex = 0;
            this.pc_name_lbl.Text = "Имя ПК";
            // 
            // pc_name_tb
            // 
            this.pc_name_tb.Location = new System.Drawing.Point(151, 12);
            this.pc_name_tb.Name = "pc_name_tb";
            this.pc_name_tb.Size = new System.Drawing.Size(286, 20);
            this.pc_name_tb.TabIndex = 1;
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(893, 365);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 2;
            this.apply_btn.Text = "Применить";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(974, 365);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // save_cfg_btn
            // 
            this.save_cfg_btn.Location = new System.Drawing.Point(212, 360);
            this.save_cfg_btn.Name = "save_cfg_btn";
            this.save_cfg_btn.Size = new System.Drawing.Size(120, 23);
            this.save_cfg_btn.TabIndex = 4;
            this.save_cfg_btn.Text = "Сохранить конфиг";
            this.save_cfg_btn.UseVisualStyleBackColor = true;
            this.save_cfg_btn.Click += new System.EventHandler(this.Save_cfg_btn_Click);
            // 
            // reb_pc_cb
            // 
            this.reb_pc_cb.AutoSize = true;
            this.reb_pc_cb.Location = new System.Drawing.Point(893, 342);
            this.reb_pc_cb.Name = "reb_pc_cb";
            this.reb_pc_cb.Size = new System.Drawing.Size(147, 17);
            this.reb_pc_cb.TabIndex = 5;
            this.reb_pc_cb.Text = "Перезагрузить сейчас?";
            this.reb_pc_cb.UseVisualStyleBackColor = true;
            // 
            // company_name_lbl
            // 
            this.company_name_lbl.AutoSize = true;
            this.company_name_lbl.Location = new System.Drawing.Point(9, 41);
            this.company_name_lbl.Name = "company_name_lbl";
            this.company_name_lbl.Size = new System.Drawing.Size(58, 13);
            this.company_name_lbl.TabIndex = 6;
            this.company_name_lbl.Text = "Компания";
            // 
            // company_name_tb
            // 
            this.company_name_tb.Location = new System.Drawing.Point(151, 39);
            this.company_name_tb.Name = "company_name_tb";
            this.company_name_tb.Size = new System.Drawing.Size(286, 20);
            this.company_name_tb.TabIndex = 7;
            // 
            // model_name_tb
            // 
            this.model_name_tb.Location = new System.Drawing.Point(151, 65);
            this.model_name_tb.Name = "model_name_tb";
            this.model_name_tb.Size = new System.Drawing.Size(286, 20);
            this.model_name_tb.TabIndex = 9;
            // 
            // model_name_lbl
            // 
            this.model_name_lbl.AutoSize = true;
            this.model_name_lbl.Location = new System.Drawing.Point(9, 68);
            this.model_name_lbl.Name = "model_name_lbl";
            this.model_name_lbl.Size = new System.Drawing.Size(64, 13);
            this.model_name_lbl.TabIndex = 8;
            this.model_name_lbl.Text = "Модель ПК";
            // 
            // suphours_tb
            // 
            this.suphours_tb.Location = new System.Drawing.Point(151, 92);
            this.suphours_tb.Name = "suphours_tb";
            this.suphours_tb.Size = new System.Drawing.Size(286, 20);
            this.suphours_tb.TabIndex = 11;
            // 
            // suphours_lbl
            // 
            this.suphours_lbl.AutoSize = true;
            this.suphours_lbl.Location = new System.Drawing.Point(9, 95);
            this.suphours_lbl.Name = "suphours_lbl";
            this.suphours_lbl.Size = new System.Drawing.Size(110, 13);
            this.suphours_lbl.TabIndex = 10;
            this.suphours_lbl.Text = "Часы техподдержки";
            // 
            // supphone_tb
            // 
            this.supphone_tb.Location = new System.Drawing.Point(151, 119);
            this.supphone_tb.Name = "supphone_tb";
            this.supphone_tb.Size = new System.Drawing.Size(286, 20);
            this.supphone_tb.TabIndex = 13;
            // 
            // supphone_lbl
            // 
            this.supphone_lbl.AutoSize = true;
            this.supphone_lbl.Location = new System.Drawing.Point(9, 122);
            this.supphone_lbl.Name = "supphone_lbl";
            this.supphone_lbl.Size = new System.Drawing.Size(127, 13);
            this.supphone_lbl.TabIndex = 12;
            this.supphone_lbl.Text = "Телефон техподдержки";
            // 
            // supurl_tb
            // 
            this.supurl_tb.Location = new System.Drawing.Point(151, 142);
            this.supurl_tb.Name = "supurl_tb";
            this.supurl_tb.Size = new System.Drawing.Size(286, 20);
            this.supurl_tb.TabIndex = 15;
            // 
            // supurl_lbl
            // 
            this.supurl_lbl.AutoSize = true;
            this.supurl_lbl.Location = new System.Drawing.Point(9, 149);
            this.supurl_lbl.Name = "supurl_lbl";
            this.supurl_lbl.Size = new System.Drawing.Size(106, 13);
            this.supurl_lbl.TabIndex = 14;
            this.supurl_lbl.Text = "Сайт техподдержки";
            // 
            // logo_tb
            // 
            this.logo_tb.Location = new System.Drawing.Point(151, 168);
            this.logo_tb.Name = "logo_tb";
            this.logo_tb.Size = new System.Drawing.Size(286, 20);
            this.logo_tb.TabIndex = 17;
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Location = new System.Drawing.Point(12, 176);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(49, 13);
            this.logo_lbl.TabIndex = 16;
            this.logo_lbl.Text = "Логотип";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fd_btn
            // 
            this.fd_btn.Location = new System.Drawing.Point(479, 159);
            this.fd_btn.Name = "fd_btn";
            this.fd_btn.Size = new System.Drawing.Size(120, 23);
            this.fd_btn.TabIndex = 18;
            this.fd_btn.Text = "Выбрать логотип";
            this.fd_btn.UseVisualStyleBackColor = true;
            this.fd_btn.Click += new System.EventHandler(this.Fd_btn_Click);
            // 
            // logo_pb
            // 
            this.logo_pb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.logo_pb.Location = new System.Drawing.Point(479, 33);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(120, 120);
            this.logo_pb.TabIndex = 19;
            this.logo_pb.TabStop = false;
            // 
            // load_cfg_btn
            // 
            this.load_cfg_btn.Location = new System.Drawing.Point(90, 360);
            this.load_cfg_btn.Name = "load_cfg_btn";
            this.load_cfg_btn.Size = new System.Drawing.Size(116, 23);
            this.load_cfg_btn.TabIndex = 22;
            this.load_cfg_btn.Text = "Загрузить конфиг";
            this.load_cfg_btn.UseVisualStyleBackColor = true;
            this.load_cfg_btn.Click += new System.EventHandler(this.Load_cfg_btn_Click_1);
            // 
            // show_info_btn
            // 
            this.show_info_btn.Location = new System.Drawing.Point(9, 360);
            this.show_info_btn.Name = "show_info_btn";
            this.show_info_btn.Size = new System.Drawing.Size(75, 23);
            this.show_info_btn.TabIndex = 23;
            this.show_info_btn.Text = "О системе";
            this.show_info_btn.UseVisualStyleBackColor = true;
            this.show_info_btn.Click += new System.EventHandler(this.Show_info_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "BMP File (120x120)";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(359, 235);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 25;
            this.clear_btn.Text = "Очистить";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // wallpaper_lbl
            // 
            this.wallpaper_lbl.AutoSize = true;
            this.wallpaper_lbl.Location = new System.Drawing.Point(12, 201);
            this.wallpaper_lbl.Name = "wallpaper_lbl";
            this.wallpaper_lbl.Size = new System.Drawing.Size(33, 13);
            this.wallpaper_lbl.TabIndex = 26;
            this.wallpaper_lbl.Text = "Обои";
            // 
            // wallpaper_tb
            // 
            this.wallpaper_tb.Location = new System.Drawing.Point(151, 198);
            this.wallpaper_tb.Name = "wallpaper_tb";
            this.wallpaper_tb.Size = new System.Drawing.Size(283, 20);
            this.wallpaper_tb.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Выбрать обои";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // wallpaper_pb
            // 
            this.wallpaper_pb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.wallpaper_pb.Location = new System.Drawing.Point(650, 35);
            this.wallpaper_pb.Name = "wallpaper_pb";
            this.wallpaper_pb.Size = new System.Drawing.Size(390, 186);
            this.wallpaper_pb.TabIndex = 29;
            this.wallpaper_pb.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "JPEG, JPG, PNG, WEBP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wallpaper_pb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wallpaper_tb);
            this.Controls.Add(this.wallpaper_lbl);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_info_btn);
            this.Controls.Add(this.load_cfg_btn);
            this.Controls.Add(this.logo_pb);
            this.Controls.Add(this.fd_btn);
            this.Controls.Add(this.logo_tb);
            this.Controls.Add(this.logo_lbl);
            this.Controls.Add(this.supurl_tb);
            this.Controls.Add(this.supurl_lbl);
            this.Controls.Add(this.supphone_tb);
            this.Controls.Add(this.supphone_lbl);
            this.Controls.Add(this.suphours_tb);
            this.Controls.Add(this.suphours_lbl);
            this.Controls.Add(this.model_name_tb);
            this.Controls.Add(this.model_name_lbl);
            this.Controls.Add(this.company_name_tb);
            this.Controls.Add(this.company_name_lbl);
            this.Controls.Add(this.reb_pc_cb);
            this.Controls.Add(this.save_cfg_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.pc_name_tb);
            this.Controls.Add(this.pc_name_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OEM Builder";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pc_name_lbl;
        private System.Windows.Forms.TextBox pc_name_tb;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button save_cfg_btn;
        private System.Windows.Forms.CheckBox reb_pc_cb;
        private System.Windows.Forms.Label company_name_lbl;
        private System.Windows.Forms.TextBox company_name_tb;
        private System.Windows.Forms.TextBox model_name_tb;
        private System.Windows.Forms.Label model_name_lbl;
        private System.Windows.Forms.TextBox suphours_tb;
        private System.Windows.Forms.Label suphours_lbl;
        private System.Windows.Forms.TextBox supphone_tb;
        private System.Windows.Forms.Label supphone_lbl;
        private System.Windows.Forms.TextBox supurl_tb;
        private System.Windows.Forms.Label supurl_lbl;
        private System.Windows.Forms.TextBox logo_tb;
        private System.Windows.Forms.Label logo_lbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fd_btn;
        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.Button load_cfg_btn;
        private System.Windows.Forms.Button show_info_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label wallpaper_lbl;
        private System.Windows.Forms.TextBox wallpaper_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox wallpaper_pb;
        private System.Windows.Forms.Label label2;
    }
}

