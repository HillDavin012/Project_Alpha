using System;
using System.Windows.Forms;

namespace Project_Alpha
{
   partial class MainForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.LeftSideMenu = new System.Windows.Forms.Panel();
         this.Main_Menu_Panel_Left = new System.Windows.Forms.Panel();
         this.WeatherReaderBtn = new System.Windows.Forms.Button();
         this.pictureBox8 = new System.Windows.Forms.PictureBox();
         this.SearchWebBtn = new System.Windows.Forms.Button();
         this.pictureBox6 = new System.Windows.Forms.PictureBox();
         this.WebReaderBtn = new System.Windows.Forms.Button();
         this.pictureBox5 = new System.Windows.Forms.PictureBox();
         this.NewsReaderBtn = new System.Windows.Forms.Button();
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.TextReaderBtn = new System.Windows.Forms.Button();
         this.pictureBox3 = new System.Windows.Forms.PictureBox();
         this.MediaPlayerBtn = new System.Windows.Forms.Button();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.EmailReaderBtn = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.Menu_Footer = new System.Windows.Forms.Panel();
         this.SettingsBtn = new System.Windows.Forms.Button();
         this.pictureBox7 = new System.Windows.Forms.PictureBox();
         this.Logo_Panel = new System.Windows.Forms.Panel();
         this.RightSideMenu = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.Debug_Title = new System.Windows.Forms.Panel();
         this.Debug = new System.Windows.Forms.Label();
         this.TopPanel = new System.Windows.Forms.Panel();
         this.RightSideMenuBtn = new System.Windows.Forms.Button();
         this.LeftSideMenuBtn = new System.Windows.Forms.Button();
         this.MainPanel = new System.Windows.Forms.Panel();
         this.Debug_Panel = new System.Windows.Forms.Panel();
         this.Debug_Livetxt = new System.Windows.Forms.RichTextBox();
         this.LeftSideMenu.SuspendLayout();
         this.Main_Menu_Panel_Left.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.Menu_Footer.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
         this.RightSideMenu.SuspendLayout();
         this.Debug_Title.SuspendLayout();
         this.TopPanel.SuspendLayout();
         this.Debug_Panel.SuspendLayout();
         this.SuspendLayout();
         // 
         // LeftSideMenu
         // 
         this.LeftSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
         this.LeftSideMenu.Controls.Add(this.Main_Menu_Panel_Left);
         this.LeftSideMenu.Controls.Add(this.Menu_Footer);
         this.LeftSideMenu.Controls.Add(this.Logo_Panel);
         this.LeftSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
         this.LeftSideMenu.Location = new System.Drawing.Point(0, 0);
         this.LeftSideMenu.Name = "LeftSideMenu";
         this.LeftSideMenu.Size = new System.Drawing.Size(260, 742);
         this.LeftSideMenu.TabIndex = 0;
         // 
         // Main_Menu_Panel_Left
         // 
         this.Main_Menu_Panel_Left.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.Main_Menu_Panel_Left.Controls.Add(this.WeatherReaderBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox8);
         this.Main_Menu_Panel_Left.Controls.Add(this.SearchWebBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox6);
         this.Main_Menu_Panel_Left.Controls.Add(this.WebReaderBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox5);
         this.Main_Menu_Panel_Left.Controls.Add(this.NewsReaderBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox4);
         this.Main_Menu_Panel_Left.Controls.Add(this.TextReaderBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox3);
         this.Main_Menu_Panel_Left.Controls.Add(this.MediaPlayerBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox2);
         this.Main_Menu_Panel_Left.Controls.Add(this.EmailReaderBtn);
         this.Main_Menu_Panel_Left.Controls.Add(this.pictureBox1);
         this.Main_Menu_Panel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Main_Menu_Panel_Left.Location = new System.Drawing.Point(0, 160);
         this.Main_Menu_Panel_Left.Name = "Main_Menu_Panel_Left";
         this.Main_Menu_Panel_Left.Size = new System.Drawing.Size(260, 522);
         this.Main_Menu_Panel_Left.TabIndex = 0;
         // 
         // WeatherReaderBtn
         // 
         this.WeatherReaderBtn.BackColor = System.Drawing.Color.Transparent;
         this.WeatherReaderBtn.FlatAppearance.BorderSize = 0;
         this.WeatherReaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.WeatherReaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.WeatherReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.WeatherReaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.WeatherReaderBtn.ForeColor = System.Drawing.Color.Green;
         this.WeatherReaderBtn.Location = new System.Drawing.Point(57, 213);
         this.WeatherReaderBtn.Name = "WeatherReaderBtn";
         this.WeatherReaderBtn.Size = new System.Drawing.Size(200, 40);
         this.WeatherReaderBtn.TabIndex = 11;
         this.WeatherReaderBtn.Text = "Weather Reader";
         this.WeatherReaderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.WeatherReaderBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox8
         // 
         this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
         this.pictureBox8.Location = new System.Drawing.Point(12, 213);
         this.pictureBox8.Name = "pictureBox8";
         this.pictureBox8.Size = new System.Drawing.Size(39, 40);
         this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox8.TabIndex = 12;
         this.pictureBox8.TabStop = false;
         // 
         // SearchWebBtn
         // 
         this.SearchWebBtn.BackColor = System.Drawing.Color.Transparent;
         this.SearchWebBtn.FlatAppearance.BorderSize = 0;
         this.SearchWebBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.SearchWebBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.SearchWebBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.SearchWebBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.SearchWebBtn.ForeColor = System.Drawing.Color.Green;
         this.SearchWebBtn.Location = new System.Drawing.Point(57, 305);
         this.SearchWebBtn.Name = "SearchWebBtn";
         this.SearchWebBtn.Size = new System.Drawing.Size(200, 40);
         this.SearchWebBtn.TabIndex = 9;
         this.SearchWebBtn.Text = "Search Web";
         this.SearchWebBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.SearchWebBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox6
         // 
         this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
         this.pictureBox6.Location = new System.Drawing.Point(12, 305);
         this.pictureBox6.Name = "pictureBox6";
         this.pictureBox6.Size = new System.Drawing.Size(39, 40);
         this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox6.TabIndex = 10;
         this.pictureBox6.TabStop = false;
         // 
         // WebReaderBtn
         // 
         this.WebReaderBtn.BackColor = System.Drawing.Color.Transparent;
         this.WebReaderBtn.FlatAppearance.BorderSize = 0;
         this.WebReaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.WebReaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.WebReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.WebReaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.WebReaderBtn.ForeColor = System.Drawing.Color.Green;
         this.WebReaderBtn.Location = new System.Drawing.Point(57, 259);
         this.WebReaderBtn.Name = "WebReaderBtn";
         this.WebReaderBtn.Size = new System.Drawing.Size(200, 40);
         this.WebReaderBtn.TabIndex = 7;
         this.WebReaderBtn.Text = "Web Reader";
         this.WebReaderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.WebReaderBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox5
         // 
         this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
         this.pictureBox5.Location = new System.Drawing.Point(12, 259);
         this.pictureBox5.Name = "pictureBox5";
         this.pictureBox5.Size = new System.Drawing.Size(39, 40);
         this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox5.TabIndex = 8;
         this.pictureBox5.TabStop = false;
         // 
         // NewsReaderBtn
         // 
         this.NewsReaderBtn.BackColor = System.Drawing.Color.Transparent;
         this.NewsReaderBtn.FlatAppearance.BorderSize = 0;
         this.NewsReaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.NewsReaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.NewsReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.NewsReaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.NewsReaderBtn.ForeColor = System.Drawing.Color.Green;
         this.NewsReaderBtn.Location = new System.Drawing.Point(57, 167);
         this.NewsReaderBtn.Name = "NewsReaderBtn";
         this.NewsReaderBtn.Size = new System.Drawing.Size(200, 40);
         this.NewsReaderBtn.TabIndex = 5;
         this.NewsReaderBtn.Text = "News Reader";
         this.NewsReaderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.NewsReaderBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox4
         // 
         this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
         this.pictureBox4.Location = new System.Drawing.Point(12, 167);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(39, 40);
         this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox4.TabIndex = 6;
         this.pictureBox4.TabStop = false;
         // 
         // TextReaderBtn
         // 
         this.TextReaderBtn.BackColor = System.Drawing.Color.Transparent;
         this.TextReaderBtn.FlatAppearance.BorderSize = 0;
         this.TextReaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.TextReaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.TextReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.TextReaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TextReaderBtn.ForeColor = System.Drawing.Color.Green;
         this.TextReaderBtn.Location = new System.Drawing.Point(57, 121);
         this.TextReaderBtn.Name = "TextReaderBtn";
         this.TextReaderBtn.Size = new System.Drawing.Size(200, 40);
         this.TextReaderBtn.TabIndex = 3;
         this.TextReaderBtn.Text = "Text Reader";
         this.TextReaderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.TextReaderBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox3
         // 
         this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
         this.pictureBox3.Location = new System.Drawing.Point(12, 121);
         this.pictureBox3.Name = "pictureBox3";
         this.pictureBox3.Size = new System.Drawing.Size(39, 40);
         this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox3.TabIndex = 4;
         this.pictureBox3.TabStop = false;
         // 
         // MediaPlayerBtn
         // 
         this.MediaPlayerBtn.BackColor = System.Drawing.Color.Transparent;
         this.MediaPlayerBtn.FlatAppearance.BorderSize = 0;
         this.MediaPlayerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.MediaPlayerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.MediaPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.MediaPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.MediaPlayerBtn.ForeColor = System.Drawing.Color.Green;
         this.MediaPlayerBtn.Location = new System.Drawing.Point(57, 75);
         this.MediaPlayerBtn.Name = "MediaPlayerBtn";
         this.MediaPlayerBtn.Size = new System.Drawing.Size(200, 40);
         this.MediaPlayerBtn.TabIndex = 1;
         this.MediaPlayerBtn.Text = "Media Player";
         this.MediaPlayerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.MediaPlayerBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
         this.pictureBox2.Location = new System.Drawing.Point(12, 75);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(39, 40);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 2;
         this.pictureBox2.TabStop = false;
         // 
         // EmailReaderBtn
         // 
         this.EmailReaderBtn.BackColor = System.Drawing.Color.Transparent;
         this.EmailReaderBtn.FlatAppearance.BorderSize = 0;
         this.EmailReaderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.EmailReaderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.EmailReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.EmailReaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.EmailReaderBtn.ForeColor = System.Drawing.Color.Green;
         this.EmailReaderBtn.Location = new System.Drawing.Point(57, 29);
         this.EmailReaderBtn.Name = "EmailReaderBtn";
         this.EmailReaderBtn.Size = new System.Drawing.Size(200, 40);
         this.EmailReaderBtn.TabIndex = 0;
         this.EmailReaderBtn.Text = "Email Reader";
         this.EmailReaderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.EmailReaderBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(12, 29);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(39, 40);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // Menu_Footer
         // 
         this.Menu_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.Menu_Footer.Controls.Add(this.SettingsBtn);
         this.Menu_Footer.Controls.Add(this.pictureBox7);
         this.Menu_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.Menu_Footer.Location = new System.Drawing.Point(0, 682);
         this.Menu_Footer.Name = "Menu_Footer";
         this.Menu_Footer.Size = new System.Drawing.Size(260, 60);
         this.Menu_Footer.TabIndex = 0;
         // 
         // SettingsBtn
         // 
         this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
         this.SettingsBtn.FlatAppearance.BorderSize = 0;
         this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
         this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
         this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.SettingsBtn.ForeColor = System.Drawing.Color.Green;
         this.SettingsBtn.Location = new System.Drawing.Point(54, 8);
         this.SettingsBtn.Name = "SettingsBtn";
         this.SettingsBtn.Size = new System.Drawing.Size(200, 40);
         this.SettingsBtn.TabIndex = 11;
         this.SettingsBtn.Text = "Settings";
         this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.SettingsBtn.UseVisualStyleBackColor = false;
         // 
         // pictureBox7
         // 
         this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
         this.pictureBox7.Location = new System.Drawing.Point(9, 8);
         this.pictureBox7.Name = "pictureBox7";
         this.pictureBox7.Size = new System.Drawing.Size(39, 40);
         this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox7.TabIndex = 12;
         this.pictureBox7.TabStop = false;
         // 
         // Logo_Panel
         // 
         this.Logo_Panel.BackgroundImage = global::Project_Alpha.Properties.Resources.ts2;
         this.Logo_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
         this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
         this.Logo_Panel.Name = "Logo_Panel";
         this.Logo_Panel.Size = new System.Drawing.Size(260, 160);
         this.Logo_Panel.TabIndex = 0;
         // 
         // RightSideMenu
         // 
         this.RightSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
         this.RightSideMenu.Controls.Add(this.Debug_Panel);
         this.RightSideMenu.Controls.Add(this.panel1);
         this.RightSideMenu.Controls.Add(this.Debug_Title);
         this.RightSideMenu.Dock = System.Windows.Forms.DockStyle.Right;
         this.RightSideMenu.Location = new System.Drawing.Point(1078, 0);
         this.RightSideMenu.Name = "RightSideMenu";
         this.RightSideMenu.Size = new System.Drawing.Size(260, 742);
         this.RightSideMenu.TabIndex = 1;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 682);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(260, 60);
         this.panel1.TabIndex = 0;
         // 
         // Debug_Title
         // 
         this.Debug_Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.Debug_Title.Controls.Add(this.Debug);
         this.Debug_Title.Dock = System.Windows.Forms.DockStyle.Top;
         this.Debug_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Debug_Title.ForeColor = System.Drawing.Color.White;
         this.Debug_Title.Location = new System.Drawing.Point(0, 0);
         this.Debug_Title.Name = "Debug_Title";
         this.Debug_Title.Size = new System.Drawing.Size(260, 140);
         this.Debug_Title.TabIndex = 0;
         // 
         // Debug
         // 
         this.Debug.AutoSize = true;
         this.Debug.Location = new System.Drawing.Point(52, 18);
         this.Debug.Name = "Debug";
         this.Debug.Size = new System.Drawing.Size(100, 32);
         this.Debug.TabIndex = 0;
         this.Debug.Text = "L.I.V.E";
         // 
         // TopPanel
         // 
         this.TopPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
         this.TopPanel.Controls.Add(this.RightSideMenuBtn);
         this.TopPanel.Controls.Add(this.LeftSideMenuBtn);
         this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
         this.TopPanel.Location = new System.Drawing.Point(260, 0);
         this.TopPanel.Name = "TopPanel";
         this.TopPanel.Size = new System.Drawing.Size(818, 60);
         this.TopPanel.TabIndex = 2;
         // 
         // RightSideMenuBtn
         // 
         this.RightSideMenuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.RightSideMenuBtn.BackColor = System.Drawing.Color.Transparent;
         this.RightSideMenuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightSideMenuBtn.BackgroundImage")));
         this.RightSideMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.RightSideMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.RightSideMenuBtn.FlatAppearance.BorderSize = 0;
         this.RightSideMenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
         this.RightSideMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
         this.RightSideMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.RightSideMenuBtn.Location = new System.Drawing.Point(761, 8);
         this.RightSideMenuBtn.Name = "RightSideMenuBtn";
         this.RightSideMenuBtn.Size = new System.Drawing.Size(51, 42);
         this.RightSideMenuBtn.TabIndex = 1;
         this.RightSideMenuBtn.UseVisualStyleBackColor = false;
         this.RightSideMenuBtn.Click += new System.EventHandler(this.RightSideMenuBtn_Click);
         // 
         // LeftSideMenuBtn
         // 
         this.LeftSideMenuBtn.BackColor = System.Drawing.Color.Transparent;
         this.LeftSideMenuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftSideMenuBtn.BackgroundImage")));
         this.LeftSideMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.LeftSideMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
         this.LeftSideMenuBtn.FlatAppearance.BorderSize = 0;
         this.LeftSideMenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
         this.LeftSideMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
         this.LeftSideMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.LeftSideMenuBtn.Location = new System.Drawing.Point(6, 8);
         this.LeftSideMenuBtn.Name = "LeftSideMenuBtn";
         this.LeftSideMenuBtn.Size = new System.Drawing.Size(51, 42);
         this.LeftSideMenuBtn.TabIndex = 0;
         this.LeftSideMenuBtn.UseVisualStyleBackColor = false;
         this.LeftSideMenuBtn.Click += new System.EventHandler(this.LeftSideMenuBtn_Click);
         // 
         // MainPanel
         // 
         this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MainPanel.Location = new System.Drawing.Point(260, 60);
         this.MainPanel.Name = "MainPanel";
         this.MainPanel.Size = new System.Drawing.Size(818, 682);
         this.MainPanel.TabIndex = 3;
         // 
         // Debug_Panel
         // 
         this.Debug_Panel.BackColor = System.Drawing.Color.Transparent;
         this.Debug_Panel.Controls.Add(this.Debug_Livetxt);
         this.Debug_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Debug_Panel.Location = new System.Drawing.Point(0, 140);
         this.Debug_Panel.Name = "Debug_Panel";
         this.Debug_Panel.Size = new System.Drawing.Size(260, 542);
         this.Debug_Panel.TabIndex = 0;
         // 
         // Debug_Livetxt
         // 
         this.Debug_Livetxt.BackColor = System.Drawing.Color.Black;
         this.Debug_Livetxt.Dock = System.Windows.Forms.DockStyle.Fill;
         this.Debug_Livetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Debug_Livetxt.ForeColor = System.Drawing.Color.Green;
         this.Debug_Livetxt.Location = new System.Drawing.Point(0, 0);
         this.Debug_Livetxt.Name = "Debug_Livetxt";
         this.Debug_Livetxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
         this.Debug_Livetxt.Size = new System.Drawing.Size(260, 542);
         this.Debug_Livetxt.TabIndex = 0;
         this.Debug_Livetxt.Text = "Hello WorldHello WorldHello WorldHello WorldHello WorldHello WorldHello World";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1338, 742);
         this.Controls.Add(this.MainPanel);
         this.Controls.Add(this.TopPanel);
         this.Controls.Add(this.RightSideMenu);
         this.Controls.Add(this.LeftSideMenu);
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Personal Assistant";
         this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.LeftSideMenu.ResumeLayout(false);
         this.Main_Menu_Panel_Left.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.Menu_Footer.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
         this.RightSideMenu.ResumeLayout(false);
         this.Debug_Title.ResumeLayout(false);
         this.Debug_Title.PerformLayout();
         this.TopPanel.ResumeLayout(false);
         this.Debug_Panel.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel LeftSideMenu;
      private System.Windows.Forms.Panel RightSideMenu;
      private System.Windows.Forms.Panel TopPanel;
      private System.Windows.Forms.Button LeftSideMenuBtn;
      private System.Windows.Forms.Button RightSideMenuBtn;
      private System.Windows.Forms.Panel MainPanel;
      private Panel Main_Menu_Panel_Left;
      private Panel Menu_Footer;
      private Panel Logo_Panel;
      private Button EmailReaderBtn;
      private PictureBox pictureBox1;
      private Button WeatherReaderBtn;
      private PictureBox pictureBox8;
      private Button SearchWebBtn;
      private PictureBox pictureBox6;
      private Button WebReaderBtn;
      private PictureBox pictureBox5;
      private Button NewsReaderBtn;
      private PictureBox pictureBox4;
      private Button TextReaderBtn;
      private PictureBox pictureBox3;
      private Button MediaPlayerBtn;
      private PictureBox pictureBox2;
      private Button SettingsBtn;
      private PictureBox pictureBox7;
      private Panel panel1;
      private Panel Debug_Title;
      private Label Debug;
      private Panel Debug_Panel;
      private RichTextBox Debug_Livetxt;
   }
}

