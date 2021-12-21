﻿
namespace CricBlast_GUI.Forms.Controls
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeSubPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.availabilityIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.availability = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.customizeTeam = new Guna.UI2.WinForms.Guna2Button();
            this.playerStats = new Guna.UI2.WinForms.Guna2Button();
            this.playMatch = new Guna.UI2.WinForms.Guna2Button();
            this.addPlayers = new Guna.UI2.WinForms.Guna2Button();
            this.myTeam = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tournament = new Guna.UI2.WinForms.Guna2Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeSubPanel
            // 
            this.homeSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.homeSubPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.SubHome;
            this.homeSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeSubPanel.Location = new System.Drawing.Point(308, 0);
            this.homeSubPanel.Name = "homeSubPanel";
            this.homeSubPanel.ShadowDecoration.Parent = this.homeSubPanel;
            this.homeSubPanel.Size = new System.Drawing.Size(956, 681);
            this.homeSubPanel.TabIndex = 12;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Home_Menu;
            this.menuPanel.Controls.Add(this.tournament);
            this.menuPanel.Controls.Add(this.availabilityIcon);
            this.menuPanel.Controls.Add(this.availability);
            this.menuPanel.Controls.Add(this.usernameLabel);
            this.menuPanel.Controls.Add(this.userPhoto);
            this.menuPanel.Controls.Add(this.customizeTeam);
            this.menuPanel.Controls.Add(this.playerStats);
            this.menuPanel.Controls.Add(this.playMatch);
            this.menuPanel.Controls.Add(this.addPlayers);
            this.menuPanel.Controls.Add(this.myTeam);
            this.menuPanel.Controls.Add(this.logout);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.ShadowDecoration.Parent = this.menuPanel;
            this.menuPanel.Size = new System.Drawing.Size(308, 681);
            this.menuPanel.TabIndex = 11;
            // 
            // availabilityIcon
            // 
            this.availabilityIcon.FillColor = System.Drawing.Color.LimeGreen;
            this.availabilityIcon.ImageRotate = 0F;
            this.availabilityIcon.Location = new System.Drawing.Point(130, 556);
            this.availabilityIcon.Name = "availabilityIcon";
            this.availabilityIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.availabilityIcon.ShadowDecoration.Parent = this.availabilityIcon;
            this.availabilityIcon.Size = new System.Drawing.Size(14, 14);
            this.availabilityIcon.TabIndex = 7;
            this.availabilityIcon.TabStop = false;
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.BackColor = System.Drawing.Color.Transparent;
            this.availability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availability.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availability.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.availability.Location = new System.Drawing.Point(144, 550);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(68, 25);
            this.availability.TabIndex = 6;
            this.availability.Text = "Online";
            this.availability.Click += new System.EventHandler(this.availability_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(122, 517);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(151, 32);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // userPhoto
            // 
            this.userPhoto.BackColor = System.Drawing.Color.Transparent;
            this.userPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPhoto.Image = global::CricBlast_GUI.Properties.Resources.User_Male_GrayBack;
            this.userPhoto.ImageRotate = 0F;
            this.userPhoto.Location = new System.Drawing.Point(52, 517);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.ShadowDecoration.Enabled = true;
            this.userPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPhoto.ShadowDecoration.Parent = this.userPhoto;
            this.userPhoto.Size = new System.Drawing.Size(64, 64);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 5;
            this.userPhoto.TabStop = false;
            this.userPhoto.Click += new System.EventHandler(this.userPhoto_Click);
            // 
            // customizeTeam
            // 
            this.customizeTeam.BackColor = System.Drawing.Color.Transparent;
            this.customizeTeam.BorderRadius = 10;
            this.customizeTeam.CheckedState.Parent = this.customizeTeam;
            this.customizeTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customizeTeam.CustomImages.Parent = this.customizeTeam;
            this.customizeTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customizeTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customizeTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customizeTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customizeTeam.DisabledState.Parent = this.customizeTeam;
            this.customizeTeam.FillColor = System.Drawing.Color.Transparent;
            this.customizeTeam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.customizeTeam.ForeColor = System.Drawing.Color.White;
            this.customizeTeam.HoverState.Parent = this.customizeTeam;
            this.customizeTeam.Location = new System.Drawing.Point(45, 321);
            this.customizeTeam.Name = "customizeTeam";
            this.customizeTeam.ShadowDecoration.Parent = this.customizeTeam;
            this.customizeTeam.Size = new System.Drawing.Size(198, 45);
            this.customizeTeam.TabIndex = 1;
            this.customizeTeam.Text = "Customize Team";
            this.customizeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customizeTeam.Click += new System.EventHandler(this.customizeTeam_Click);
            // 
            // playerStats
            // 
            this.playerStats.BackColor = System.Drawing.Color.Transparent;
            this.playerStats.BorderRadius = 10;
            this.playerStats.CheckedState.Parent = this.playerStats;
            this.playerStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerStats.CustomImages.Parent = this.playerStats;
            this.playerStats.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playerStats.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playerStats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playerStats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playerStats.DisabledState.Parent = this.playerStats;
            this.playerStats.FillColor = System.Drawing.Color.Transparent;
            this.playerStats.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playerStats.ForeColor = System.Drawing.Color.White;
            this.playerStats.HoverState.Parent = this.playerStats;
            this.playerStats.Location = new System.Drawing.Point(45, 195);
            this.playerStats.Name = "playerStats";
            this.playerStats.ShadowDecoration.Parent = this.playerStats;
            this.playerStats.Size = new System.Drawing.Size(198, 45);
            this.playerStats.TabIndex = 1;
            this.playerStats.Text = "Player Stats";
            this.playerStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playerStats.Click += new System.EventHandler(this.playerStats_Click);
            // 
            // playMatch
            // 
            this.playMatch.BackColor = System.Drawing.Color.Transparent;
            this.playMatch.BorderRadius = 10;
            this.playMatch.CheckedState.Parent = this.playMatch;
            this.playMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playMatch.CustomImages.Parent = this.playMatch;
            this.playMatch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playMatch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playMatch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playMatch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playMatch.DisabledState.Parent = this.playMatch;
            this.playMatch.FillColor = System.Drawing.Color.Transparent;
            this.playMatch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playMatch.ForeColor = System.Drawing.Color.White;
            this.playMatch.HoverState.Parent = this.playMatch;
            this.playMatch.Location = new System.Drawing.Point(45, 384);
            this.playMatch.Name = "playMatch";
            this.playMatch.ShadowDecoration.Parent = this.playMatch;
            this.playMatch.Size = new System.Drawing.Size(198, 45);
            this.playMatch.TabIndex = 1;
            this.playMatch.Text = "Play a Match";
            this.playMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playMatch.Click += new System.EventHandler(this.playMatch_Click);
            // 
            // addPlayers
            // 
            this.addPlayers.BackColor = System.Drawing.Color.Transparent;
            this.addPlayers.BorderRadius = 10;
            this.addPlayers.CheckedState.Parent = this.addPlayers;
            this.addPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlayers.CustomImages.Parent = this.addPlayers;
            this.addPlayers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addPlayers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addPlayers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addPlayers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addPlayers.DisabledState.Parent = this.addPlayers;
            this.addPlayers.FillColor = System.Drawing.Color.Transparent;
            this.addPlayers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.addPlayers.ForeColor = System.Drawing.Color.White;
            this.addPlayers.HoverState.Parent = this.addPlayers;
            this.addPlayers.Location = new System.Drawing.Point(45, 258);
            this.addPlayers.Name = "addPlayers";
            this.addPlayers.ShadowDecoration.Parent = this.addPlayers;
            this.addPlayers.Size = new System.Drawing.Size(198, 45);
            this.addPlayers.TabIndex = 1;
            this.addPlayers.Text = "Add Players";
            this.addPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addPlayers.Click += new System.EventHandler(this.addPlayers_Click);
            // 
            // myTeam
            // 
            this.myTeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myTeam.BackColor = System.Drawing.Color.Transparent;
            this.myTeam.BorderRadius = 10;
            this.myTeam.CheckedState.Parent = this.myTeam;
            this.myTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTeam.CustomImages.Parent = this.myTeam;
            this.myTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.myTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.myTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.myTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.myTeam.DisabledState.Parent = this.myTeam;
            this.myTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.myTeam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.myTeam.ForeColor = System.Drawing.Color.White;
            this.myTeam.HoverState.Parent = this.myTeam;
            this.myTeam.Location = new System.Drawing.Point(45, 132);
            this.myTeam.Name = "myTeam";
            this.myTeam.ShadowDecoration.Parent = this.myTeam;
            this.myTeam.Size = new System.Drawing.Size(198, 45);
            this.myTeam.TabIndex = 1;
            this.myTeam.Text = "My Team";
            this.myTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.myTeam.Click += new System.EventHandler(this.myTeam_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.logout.Location = new System.Drawing.Point(109, 594);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 30);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(103, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "CricBlast";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(45, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tournament
            // 
            this.tournament.BackColor = System.Drawing.Color.Transparent;
            this.tournament.BorderRadius = 10;
            this.tournament.CheckedState.Parent = this.tournament;
            this.tournament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tournament.CustomImages.Parent = this.tournament;
            this.tournament.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tournament.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tournament.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tournament.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tournament.DisabledState.Parent = this.tournament;
            this.tournament.FillColor = System.Drawing.Color.Transparent;
            this.tournament.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.tournament.ForeColor = System.Drawing.Color.White;
            this.tournament.HoverState.Parent = this.tournament;
            this.tournament.Location = new System.Drawing.Point(45, 447);
            this.tournament.Name = "tournament";
            this.tournament.ShadowDecoration.Parent = this.tournament;
            this.tournament.Size = new System.Drawing.Size(198, 45);
            this.tournament.TabIndex = 8;
            this.tournament.Text = "Tournament";
            this.tournament.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tournament.Click += new System.EventHandler(this.tournament_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.homeSubPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox availabilityIcon;
        private System.Windows.Forms.Label availability;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPhoto;
        private Guna.UI2.WinForms.Guna2Button customizeTeam;
        private Guna.UI2.WinForms.Guna2Button playerStats;
        private Guna.UI2.WinForms.Guna2Button playMatch;
        private Guna.UI2.WinForms.Guna2Button addPlayers;
        private Guna.UI2.WinForms.Guna2Button myTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel homeSubPanel;
        private System.Windows.Forms.Label logout;
        private Guna.UI2.WinForms.Guna2Button tournament;
    }
}
