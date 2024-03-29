﻿namespace Kardex
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_user = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.lbl_error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Iniciar sesión";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.IdleForecolor = System.Drawing.Color.White;
            this.btn_login.IdleLineColor = System.Drawing.Color.LightSkyBlue;
            this.btn_login.Location = new System.Drawing.Point(642, 349);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(167, 54);
            this.btn_login.TabIndex = 3;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btn_login, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_login, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_login, "");
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_user
            // 
            this.txt_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_user.HintForeColor = System.Drawing.Color.Empty;
            this.txt_user.HintText = "Usuario";
            this.txt_user.isPassword = false;
            this.txt_user.LineFocusedColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_user.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_user.LineMouseHoverColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_user.LineThickness = 2;
            this.txt_user.Location = new System.Drawing.Point(486, 183);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.MaxLength = 32767;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(323, 32);
            this.txt_user.TabIndex = 4;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuToolTip1.SetToolTip(this.txt_user, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txt_user, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txt_user, "");
            // 
            // txt_pass
            // 
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_pass.HintText = "contraseña";
            this.txt_pass.isPassword = true;
            this.txt_pass.LineFocusedColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_pass.LineMouseHoverColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.LineThickness = 2;
            this.txt_pass.Location = new System.Drawing.Point(486, 254);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(323, 32);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuToolTip1.SetToolTip(this.txt_pass, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txt_pass, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txt_pass, "");
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(460, 33);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(251, 54);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Iniciar sesión";
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomLabel1, "");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 427);
            this.panel1.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // btn_close
            // 
            this.btn_close.ActiveBorderThickness = 1;
            this.btn_close.ActiveCornerRadius = 20;
            this.btn_close.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_close.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_close.ActiveLineColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.ButtonText = "X";
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_close.IdleBorderThickness = 1;
            this.btn_close.IdleCornerRadius = 20;
            this.btn_close.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_close.IdleForecolor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_close.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(818, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 29);
            this.btn_close.TabIndex = 9;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btn_close, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btn_close, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btn_close, "");
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(464, 101);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(345, 28);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Accede mediante tu cuenta institucional";
            this.bunifuToolTip1.SetToolTip(this.bunifuCustomLabel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuCustomLabel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuCustomLabel2, "");
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = true;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = "txt_user";
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Tahoma", 7F);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(477, 302);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(332, 42);
            this.lbl_error.TabIndex = 11;
            this.lbl_error.Text = "Contraseña o identificador de usuario incorrectos. \r\nEscriba la contraseña y el i" +
    "dentificador de usuario correctos \r\ne inténtelo de nuevo.";
            this.bunifuToolTip1.SetToolTip(this.lbl_error, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lbl_error, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lbl_error, "");
            this.lbl_error.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 427);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control escolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_close;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_error;
    }
}