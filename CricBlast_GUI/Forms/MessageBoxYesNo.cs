﻿using System;
using System.Media;
using System.Windows.Forms;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms
{
    public partial class MessageBoxYesNo : Form
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

        public MessageBoxYesNo(byte mark, string message)
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();

            this.message.Text = message;
            switch (mark)
            {
                case 0:
                    SystemSounds.Asterisk.Play();
                    messageMark.Image = Properties.Resources.Check_Mark;
                    break;
                case 1:
                    SystemSounds.Exclamation.Play();
                    messageMark.Image = Properties.Resources.Warning_Mark;
                    break;
                default:
                    SystemSounds.Hand.Play();
                    messageMark.Image = Properties.Resources.Error_Mark;
                    break;
            }
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Selected.MessageBoxYesOrNo = true;
            Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            Selected.MessageBoxYesOrNo = false;
            Close();
        }
    }
}