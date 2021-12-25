﻿
namespace CricBlast_GUI.UI.Admin_Controls
{
    partial class ManageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dbPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.UserDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.User = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Won = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.viewDetails = new Guna.UI2.WinForms.Guna2Button();
            this.modify = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.dbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbPanel
            // 
            this.dbPanel.AutoRoundedCorners = true;
            this.dbPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.dbPanel.BorderRadius = 206;
            this.dbPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.dbPanel.BorderThickness = 5;
            this.dbPanel.Controls.Add(this.UserDataGridView);
            this.dbPanel.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.dbPanel.Location = new System.Drawing.Point(59, 126);
            this.dbPanel.Name = "dbPanel";
            this.dbPanel.ShadowDecoration.Parent = this.dbPanel;
            this.dbPanel.Size = new System.Drawing.Size(839, 415);
            this.dbPanel.TabIndex = 38;
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToAddRows = false;
            this.UserDataGridView.AllowUserToDeleteRows = false;
            this.UserDataGridView.AllowUserToOrderColumns = true;
            this.UserDataGridView.AllowUserToResizeColumns = false;
            this.UserDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.UserDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserDataGridView.ColumnHeadersHeight = 40;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.UserName,
            this.Email,
            this.Password,
            this.Joined,
            this.Played,
            this.Won});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataGridView.EnableHeadersVisualStyles = false;
            this.UserDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UserDataGridView.MultiSelect = false;
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.ReadOnly = true;
            this.UserDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDataGridView.RowHeadersVisible = false;
            this.UserDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDataGridView.RowTemplate.Height = 30;
            this.UserDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(839, 415);
            this.UserDataGridView.TabIndex = 31;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.UserDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.UserDataGridView.ThemeStyle.ReadOnly = true;
            this.UserDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UserDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.UserDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.User.HeaderText = "";
            this.User.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.User.Width = 47;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.HeaderText = "NAME";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 135;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.HeaderText = "EMAIL ADDRESS";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 280;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Password.DefaultCellStyle = dataGridViewCellStyle3;
            this.Password.HeaderText = "PASSWORD";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 120;
            // 
            // Joined
            // 
            this.Joined.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Joined.DefaultCellStyle = dataGridViewCellStyle4;
            this.Joined.HeaderText = "JOINED";
            this.Joined.Name = "Joined";
            this.Joined.ReadOnly = true;
            this.Joined.Width = 113;
            // 
            // Played
            // 
            this.Played.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Played.DefaultCellStyle = dataGridViewCellStyle5;
            this.Played.HeaderText = "PLAYED";
            this.Played.Name = "Played";
            this.Played.ReadOnly = true;
            this.Played.Width = 70;
            // 
            // Won
            // 
            this.Won.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Won.DefaultCellStyle = dataGridViewCellStyle6;
            this.Won.HeaderText = "  WON";
            this.Won.Name = "Won";
            this.Won.ReadOnly = true;
            this.Won.Width = 75;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(268, 42);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(420, 65);
            this.welcomeLabel.TabIndex = 35;
            this.welcomeLabel.Text = "MANAGE USER";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewDetails
            // 
            this.viewDetails.BackColor = System.Drawing.Color.Transparent;
            this.viewDetails.BorderRadius = 4;
            this.viewDetails.CheckedState.Parent = this.viewDetails;
            this.viewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDetails.CustomImages.Parent = this.viewDetails;
            this.viewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewDetails.DisabledState.Parent = this.viewDetails;
            this.viewDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.viewDetails.ForeColor = System.Drawing.Color.White;
            this.viewDetails.HoverState.Parent = this.viewDetails;
            this.viewDetails.Location = new System.Drawing.Point(591, 576);
            this.viewDetails.Name = "viewDetails";
            this.viewDetails.ShadowDecoration.Parent = this.viewDetails;
            this.viewDetails.Size = new System.Drawing.Size(180, 45);
            this.viewDetails.TabIndex = 45;
            this.viewDetails.Text = "View Details";
            this.viewDetails.Click += new System.EventHandler(this.viewDetails_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.BorderRadius = 4;
            this.modify.CheckedState.Parent = this.modify;
            this.modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modify.CustomImages.Parent = this.modify;
            this.modify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modify.DisabledState.Parent = this.modify;
            this.modify.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.HoverState.Parent = this.modify;
            this.modify.Location = new System.Drawing.Point(388, 576);
            this.modify.Name = "modify";
            this.modify.ShadowDecoration.Parent = this.modify;
            this.modify.Size = new System.Drawing.Size(180, 45);
            this.modify.TabIndex = 46;
            this.modify.Text = "Modify";
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BorderRadius = 4;
            this.delete.CheckedState.Parent = this.delete;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.CustomImages.Parent = this.delete;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.DisabledState.Parent = this.delete;
            this.delete.FillColor = System.Drawing.Color.Tomato;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.HoverState.Parent = this.delete;
            this.delete.Location = new System.Drawing.Point(184, 576);
            this.delete.Name = "delete";
            this.delete.ShadowDecoration.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(180, 45);
            this.delete.TabIndex = 47;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.SubHome;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.viewDetails);
            this.Controls.Add(this.dbPanel);
            this.Controls.Add(this.welcomeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ManageUser";
            this.Size = new System.Drawing.Size(956, 681);
            this.dbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dbPanel;
        private Guna.UI2.WinForms.Guna2DataGridView UserDataGridView;
        public System.Windows.Forms.Label welcomeLabel;
        private Guna.UI2.WinForms.Guna2Button viewDetails;
        private Guna.UI2.WinForms.Guna2Button modify;
        private Guna.UI2.WinForms.Guna2Button delete;
        private System.Windows.Forms.DataGridViewImageColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joined;
        private System.Windows.Forms.DataGridViewTextBoxColumn Played;
        private System.Windows.Forms.DataGridViewTextBoxColumn Won;
    }
}
