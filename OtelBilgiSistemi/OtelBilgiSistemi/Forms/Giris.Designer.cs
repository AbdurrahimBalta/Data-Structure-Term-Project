﻿namespace OtelBilgiSistemi
{
    partial class Giris
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
            this.kayitBtn = new MetroFramework.Controls.MetroButton();
            this.girisBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.girisSifreTbox = new MetroFramework.Controls.MetroTextBox();
            this.girisEpostaTbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // kayitBtn
            // 
            this.kayitBtn.Location = new System.Drawing.Point(403, 240);
            this.kayitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(108, 31);
            this.kayitBtn.TabIndex = 12;
            this.kayitBtn.Text = "KAYIT OL";
            this.kayitBtn.UseSelectable = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(272, 240);
            this.girisBtn.Margin = new System.Windows.Forms.Padding(4);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(104, 31);
            this.girisBtn.TabIndex = 11;
            this.girisBtn.Text = "GİRİŞ";
            this.girisBtn.UseSelectable = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(193, 172);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 20);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Şifre";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(172, 111);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "E Posta";
            // 
            // girisSifreTbox
            // 
            // 
            // 
            // 
            this.girisSifreTbox.CustomButton.Image = null;
            this.girisSifreTbox.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.girisSifreTbox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.girisSifreTbox.CustomButton.Name = "";
            this.girisSifreTbox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.girisSifreTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.girisSifreTbox.CustomButton.TabIndex = 1;
            this.girisSifreTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.girisSifreTbox.CustomButton.UseSelectable = true;
            this.girisSifreTbox.CustomButton.Visible = false;
            this.girisSifreTbox.Lines = new string[0];
            this.girisSifreTbox.Location = new System.Drawing.Point(272, 172);
            this.girisSifreTbox.Margin = new System.Windows.Forms.Padding(4);
            this.girisSifreTbox.MaxLength = 32767;
            this.girisSifreTbox.Name = "girisSifreTbox";
            this.girisSifreTbox.PasswordChar = '\0';
            this.girisSifreTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.girisSifreTbox.SelectedText = "";
            this.girisSifreTbox.SelectionLength = 0;
            this.girisSifreTbox.SelectionStart = 0;
            this.girisSifreTbox.ShortcutsEnabled = true;
            this.girisSifreTbox.Size = new System.Drawing.Size(239, 28);
            this.girisSifreTbox.TabIndex = 8;
            this.girisSifreTbox.UseSelectable = true;
            this.girisSifreTbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.girisSifreTbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // girisEpostaTbox
            // 
            // 
            // 
            // 
            this.girisEpostaTbox.CustomButton.Image = null;
            this.girisEpostaTbox.CustomButton.Location = new System.Drawing.Point(213, 2);
            this.girisEpostaTbox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.girisEpostaTbox.CustomButton.Name = "";
            this.girisEpostaTbox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.girisEpostaTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.girisEpostaTbox.CustomButton.TabIndex = 1;
            this.girisEpostaTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.girisEpostaTbox.CustomButton.UseSelectable = true;
            this.girisEpostaTbox.CustomButton.Visible = false;
            this.girisEpostaTbox.Lines = new string[0];
            this.girisEpostaTbox.Location = new System.Drawing.Point(272, 111);
            this.girisEpostaTbox.Margin = new System.Windows.Forms.Padding(4);
            this.girisEpostaTbox.MaxLength = 32767;
            this.girisEpostaTbox.Name = "girisEpostaTbox";
            this.girisEpostaTbox.PasswordChar = '\0';
            this.girisEpostaTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.girisEpostaTbox.SelectedText = "";
            this.girisEpostaTbox.SelectionLength = 0;
            this.girisEpostaTbox.SelectionStart = 0;
            this.girisEpostaTbox.ShortcutsEnabled = true;
            this.girisEpostaTbox.Size = new System.Drawing.Size(239, 28);
            this.girisEpostaTbox.TabIndex = 7;
            this.girisEpostaTbox.UseSelectable = true;
            this.girisEpostaTbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.girisEpostaTbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 352);
            this.Controls.Add(this.kayitBtn);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.girisSifreTbox);
            this.Controls.Add(this.girisEpostaTbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "HotelFinder";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton kayitBtn;
        private MetroFramework.Controls.MetroButton girisBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox girisSifreTbox;
        private MetroFramework.Controls.MetroTextBox girisEpostaTbox;
    }
}

