﻿using System;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Admin_Controls
{
    public partial class ProjectDetails : UserControl
    {
        public ProjectDetails()
        {
            InitializeComponent();
        }

        private void infoPicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Raofin/CricBlast");
        }
    }
}
