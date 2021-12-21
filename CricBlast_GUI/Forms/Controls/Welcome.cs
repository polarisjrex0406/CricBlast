﻿using CricBlast_GUI.Home;
using System.Windows.Forms;
using CricBlast_GUI.Database;
using CricBlast_GUI.Forms.Admin_Controls;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class Welcome : UserControl
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private bool _eye;
        private bool _admin;

        public Welcome()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        private void eyePicture_Click(object sender, System.EventArgs e)
        {
            switch (_eye)
            {
                case true:
                    eyePicture.Image = Properties.Resources.Eye_Close;
                    _eye = false;
                    passwordTextBox.UseSystemPasswordChar = true;
                    return;
                case false:
                    eyePicture.Image = Properties.Resources.Eye_Open;
                    _eye = true;
                    passwordTextBox.UseSystemPasswordChar = false;
                    break;
            }
        }


        private void refreshPicture_Click(object sender, System.EventArgs e)
        {
            switch (_admin)
            {
                case true:
                    loginAsPicture.Image = Properties.Resources.Unknown_User;
                    _admin = false;
                    logo.Image = Properties.Resources.Logo;
                    usernameLabel.Text = "USERNAME OR EMAIL";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    createAccountLabel.Visible = true;
                    label5.Visible = true;
                    return;
                case false:
                    loginAsPicture.Image = Properties.Resources.Admin_Colored;
                    _admin = true;
                    logo.Image = Properties.Resources.Admin_Logo;
                    usernameLabel.Text = "ADMIN NAME OR EMAIL";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    createAccountLabel.Visible = false;
                    label5.Visible = false;
                    break;
            }
        }

        private void login_Click(object sender, System.EventArgs e)
        {
            usernameRequired.Visible = string.IsNullOrWhiteSpace(usernameTextBox.Text);
            passwordRequired.Visible = string.IsNullOrWhiteSpace(passwordTextBox.Text);

            if (!usernameRequired.Visible && !passwordRequired.Visible)
                switch (_admin)
                {
                    case true when usernameTextBox.Text.ToLower() == "admin" && passwordTextBox.Text.ToLower() == "admin":
                        new MessageBoxOk(Selected.CheckMark, "You have successfully logged in.").Show();
                        Controls.Clear();
                        Controls.Add(new AdminPanel());
                        return;
                    case false when Login.Verify(usernameTextBox.Text, passwordTextBox.Text):
                        new MessageBoxOk(Selected.CheckMark, "You have successfully logged in.").Show();
                        Controls.Clear();
                        Controls.Add(new Home());
                        return;
                    default:
                        new MessageBoxOk(Selected.ErrorMark, "Bad credentials. Please login again.").ShowDialog();
                        break;
                }
            else
                new MessageBoxOk(Selected.WarningMark, "Please fill out all the fields properly.").ShowDialog();
        }

        private void forgotPassword_Click(object sender, System.EventArgs e)
        {
            switch (_admin)
            {
                case true:
                    usernameTextBox.Text = "admin";
                    passwordTextBox.Text = "admin";
                    return;
                default:
                    new Recover().ShowDialog();
                    usernameTextBox.Text = Selected.UserDetails[2];
                    passwordTextBox.Text = Selected.UserDetails[3];
                    break;
            }
        }

        private void createAccountLabel_Click(object sender, System.EventArgs e)
        {
            Controls.Clear();
            Controls.Add(value: new CreateAccount());
        }

        private void Welcome_Load(object sender, System.EventArgs e)
        {
            usernameTextBox.Text = Selected.UserDetails[2];
            passwordTextBox.Text = Selected.UserDetails[3];
        }

        private void usernameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            usernameRequired.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            passwordRequired.Visible = false;
        }
    }
}