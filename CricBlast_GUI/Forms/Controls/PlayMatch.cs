﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class PlayMatch : UserControl
    {
        public PlayMatch()
        {
            InitializeComponent();
        }

        private void opponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.OpponentTeam = opponentComboBox.SelectedIndex;
        }
    }
}
