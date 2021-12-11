﻿using System;
using System.Windows.Forms;
using CricBlast_GUI.Home;

namespace CricBlast_GUI.Forms
{
    public partial class ChooseTeam : Form
    {
        public ChooseTeam()
        {
            InitializeComponent();
        }
        
        private void ChooseTeam_Load(object sender, EventArgs e)
        {
            teamComboBox.SelectedIndex = Selected.UserTeam == 0 ? 0 : Selected.UserTeam + 1;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (teamComboBox.SelectedIndex == 0)
            {
                teamSelectError.Visible = true;
                return;
            }

            Selected.UserTeam = Selected.TeamNumber(teamComboBox.SelectedItem.ToString());
            Selected.UserTeamLogo = Teams.Logo.GetLogo(Selected.UserTeam);
            Selected.UserTeamPlayerStats = Players.Stats.GetTeamPlayers(Selected.UserTeam);
            Close();
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamSelectError.Visible = teamComboBox.SelectedIndex == 0;
        }
    }
}