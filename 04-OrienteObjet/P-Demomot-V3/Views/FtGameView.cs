using P_Demomot.Controllers;
using P_Demomot.Models.Characters;
using P_Demomot.Controllers.FightTactics;
using P_Demomot.Models.UserInfos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace P_Demomot.Views
{
    public partial class FtGameView : Form, IView
    {
        private MainController _mainController;         // Main controller
        private FtGameController _ftGameController;     // Ft game controller

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public ft game controller
        /// </summary>
        public FtGameController FtGameController
        {
            get { return _ftGameController; }
            set { _ftGameController = value; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public FtGameView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FtGameView_Load(object sender, EventArgs e)
        {
            Display();
        }

        /// <summary>
        /// Display the whole page
        /// </summary>
        public void Display()
        {
            lblTurn.Text = "Tour de Joueur1";

            // Set the team 1
            Team team1 = _ftGameController.GetTeam(1);
            lblFighter1name.Text = team1.CharactersList[0].Name;
            lblFighter2name.Text = team1.CharactersList[1].Name;
            lblFighter3name.Text = team1.CharactersList[2].Name;
            // Get the power names
            Dictionary<string, string> character1PowersName = _ftGameController.GetPowersName(team1.CharactersList[0].Name);
            Dictionary<string, string> character2PowersName = _ftGameController.GetPowersName(team1.CharactersList[1].Name);
            Dictionary<string, string> character3PowersName = _ftGameController.GetPowersName(team1.CharactersList[2].Name);

            // Set the first character
            rdoCharacter1Power1.Text = team1.CharactersList[0].Power[JToken.Parse(character1PowersName["Power1"]).ToString()].Name;
            rdoCharacter1Power2.Text = team1.CharactersList[0].Power[JToken.Parse(character1PowersName["Power2"]).ToString()].Name;
            if (team1.CharactersList[0].Power.Count() == 3)
            {
                rdoCharacter1Power3.Text = team1.CharactersList[0].Power[JToken.Parse(character1PowersName["Power3"]).ToString()].Name;
            }
            else
            {
                rdoCharacter1Power3.Visible = false;
            }
            pgbTeamOneFighterOneLife.Maximum = team1.CharactersList[0].Life;
            pgbTeamOneFighterOneLife.Value = team1.CharactersList[0].Life;

            // Set the second character
            rdoCharacter2Power1.Text = team1.CharactersList[1].Power[JToken.Parse(character2PowersName["Power1"]).ToString()].Name;
            rdoCharacter2Power2.Text = team1.CharactersList[1].Power[JToken.Parse(character2PowersName["Power2"]).ToString()].Name;
            if (team1.CharactersList[1].Power.Count() == 3)
            {
                rdoCharacter2Power3.Text = team1.CharactersList[1].Power[JToken.Parse(character2PowersName["Power3"]).ToString()].Name;
            }
            else
            {
                rdoCharacter2Power3.Visible = false;
            }
            pgbTeamOneFighterTwoLife.Maximum = team1.CharactersList[1].Life;
            pgbTeamOneFighterTwoLife.Value = team1.CharactersList[1].Life;

            // Set the third character
            rdoCharacter3Power1.Text = team1.CharactersList[2].Power[JToken.Parse(character3PowersName["Power1"]).ToString()].Name;
            rdoCharacter3Power2.Text = team1.CharactersList[2].Power[JToken.Parse(character3PowersName["Power2"]).ToString()].Name;
            if (team1.CharactersList[2].Power.Count() == 3)
            {
                rdoCharacter3Power3.Text = team1.CharactersList[2].Power[JToken.Parse(character3PowersName["Power3"]).ToString()].Name;
            }
            else
            {
                rdoCharacter3Power3.Visible = false;
            }
            pgbTeamOneFighterThreeLife.Maximum = team1.CharactersList[2].Life;
            pgbTeamOneFighterThreeLife.Value = team1.CharactersList[2].Life;

            // Set the team 2
            Team team2 = _ftGameController.GetTeam(2);
            lblFighter4name.Text = team2.CharactersList[0].Name;
            lblFighter5name.Text = team2.CharactersList[1].Name;
            lblFighter6name.Text = team2.CharactersList[2].Name;

            // Get the power names
            Dictionary<string, string> character4PowersName = _ftGameController.GetPowersName(team2.CharactersList[0].Name);
            Dictionary<string, string> character5PowersName = _ftGameController.GetPowersName(team2.CharactersList[1].Name);
            Dictionary<string, string> character6PowersName = _ftGameController.GetPowersName(team2.CharactersList[2].Name);

            // Set the first character
            rdoCharacter4Power1.Text = team2.CharactersList[0].Power[JToken.Parse(character4PowersName["Power1"]).ToString()].Name;
            rdoCharacter4Power2.Text = team2.CharactersList[0].Power[JToken.Parse(character4PowersName["Power2"]).ToString()].Name;
            if (team2.CharactersList[0].Power.Count() == 3)
            {
                rdoCharacter4Power3.Text = team2.CharactersList[0].Power[JToken.Parse(character4PowersName["Power3"]).ToString()].Name;
            }
            else
            {
                rdoCharacter4Power3.Visible = false;
            }
            pgbTeamTwoFighterOneLife.Maximum = team2.CharactersList[0].Life;
            pgbTeamTwoFighterOneLife.Value = team2.CharactersList[0].Life;

            // Set the second character
            rdoCharacter5Power1.Text = team2.CharactersList[1].Power[JToken.Parse(character5PowersName["Power1"]).ToString()].Name;
            rdoCharacter5Power2.Text = team2.CharactersList[1].Power[JToken.Parse(character5PowersName["Power2"]).ToString()].Name;
            if (team2.CharactersList[1].Power.Count() == 3)
            {
                rdoCharacter5Power3.Text = team2.CharactersList[1].Power[JToken.Parse(character5PowersName["Power3"]).ToString()].Name;
            }
            else
            {
                rdoCharacter5Power3.Visible = false;
            }
            pgbTeamTwoFighterTwoLife.Maximum = team2.CharactersList[1].Life;
            pgbTeamTwoFighterTwoLife.Value = team2.CharactersList[1].Life;

            // Set the third character
            rdoCharacter6Power1.Text = team2.CharactersList[2].Power[JToken.Parse(character6PowersName["Power1"]).ToString()].Name;
            rdoCharacter6Power2.Text = team2.CharactersList[2].Power[JToken.Parse(character6PowersName["Power2"]).ToString()].Name;
            if (team2.CharactersList[2].Power.Count() == 3)
            {
                rdoCharacter6Power3.Text = team2.CharactersList[2].Power[JToken.Parse(character6PowersName["Power3"]).ToString()].Name;
            }
            else
            {
                rdoCharacter6Power3.Visible = false;
            }
            pgbTeamTwoFighterThreeLife.Maximum = team2.CharactersList[2].Life;
            pgbTeamTwoFighterThreeLife.Value = team2.CharactersList[2].Life;
        }

        //TEAM ONE
        /// <summary>
        /// Fighter one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamOneFighterOne_Click(object sender, EventArgs e)
        {
            // Check if the character is dead
            if(pgbTeamOneFighterOneLife.Value != 0)
            {
                _ftGameController.Attack(1);
            }
            else
            {
                MessageBox.Show("This character is already dead");
            }
        }

        /// <summary>
        /// Fighter two
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamOneFighterTwo_Click(object sender, EventArgs e)
        {
            // Check if the character is dead
            if (pgbTeamOneFighterTwoLife.Value != 0)
            {
                _ftGameController.Attack(2);
            }
            else
            {
                MessageBox.Show("This character is already dead");
            }
        }

        /// <summary>
        /// Fighter three
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamOneFighterThree_Click(object sender, EventArgs e)
        {
            // Check if the character is dead
            if (pgbTeamOneFighterThreeLife.Value != 0)
            {
                _ftGameController.Attack(3);
            }
            else
            {
                MessageBox.Show("This character is already dead");
            }
        }


        // TEAM TWO
        /// <summary>
        /// Fighter four
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamTwoFighterOne_Click(object sender, EventArgs e)
        {
            // Check if the character is dead
            if (pgbTeamTwoFighterOneLife.Value != 0)
            {
                _ftGameController.Attack(4);
            }
            else
            {
                MessageBox.Show("This character is already dead");
            }
        }

        /// <summary>
        /// Fighter five
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamTwoFighterTwo_Click(object sender, EventArgs e)
        {
            // Check if the character is dead
            if (pgbTeamTwoFighterTwoLife.Value != 0)
            {
                _ftGameController.Attack(5);
            }
            else
            {
                MessageBox.Show("This character is already dead");
            }
        }

        /// <summary>
        /// Fighter six
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamTwoFighterThree_Click(object sender, EventArgs e)
        {
            // Check if the character is dead
            if (pgbTeamTwoFighterThreeLife.Value != 0)
            {
                _ftGameController.Attack(6);
            }
            else
            {
                MessageBox.Show("This character is already dead");
            }
        }

        /// <summary>
        /// Get the name of the power used
        /// </summary>
        /// <param name="attacker">attacker</param>
        /// <returns>Return the name of the power</returns>
        public string PowerNameUsed(int attacker)
        {
            string name = "";
            switch(attacker)
            {
                case 1:
                    if(rdoCharacter1Power1.Checked == true)
                    {
                        name = rdoCharacter1Power1.Text;
                    }
                    else if(rdoCharacter1Power2.Checked == true)
                    {
                        name = rdoCharacter1Power2.Text;
                    }
                    else if (rdoCharacter1Power3.Checked == true)
                    {
                        name = rdoCharacter1Power3.Text;
                    }
                    break;
                case 2:
                    if (rdoCharacter4Power1.Checked == true)
                    {
                        name = rdoCharacter4Power1.Text;
                    }
                    else if (rdoCharacter4Power2.Checked == true)
                    {
                        name = rdoCharacter4Power2.Text;
                    }
                    else if (rdoCharacter4Power3.Checked == true)
                    {
                        name = rdoCharacter4Power3.Text;
                    }
                    break;
                case 3:
                    if (rdoCharacter2Power1.Checked == true)
                    {
                        name = rdoCharacter2Power1.Text;
                    }
                    else if (rdoCharacter2Power2.Checked == true)
                    {
                        name = rdoCharacter2Power2.Text;
                    }
                    else if (rdoCharacter2Power3.Checked == true)
                    {
                        name = rdoCharacter2Power3.Text;
                    }
                    break;
                case 4:
                    if (rdoCharacter5Power1.Checked == true)
                    {
                        name = rdoCharacter5Power1.Text;
                    }
                    else if (rdoCharacter5Power2.Checked == true)
                    {
                        name = rdoCharacter5Power2.Text;
                    }
                    else if (rdoCharacter5Power3.Checked == true)
                    {
                        name = rdoCharacter5Power3.Text;
                    }
                    break;
                case 5:
                    if (rdoCharacter3Power1.Checked == true)
                    {
                        name = rdoCharacter3Power1.Text;
                    }
                    else if (rdoCharacter3Power2.Checked == true)
                    {
                        name = rdoCharacter3Power2.Text;
                    }
                    else if (rdoCharacter3Power3.Checked == true)
                    {
                        name = rdoCharacter3Power3.Text;
                    }
                    break;
                case 6:
                    if (rdoCharacter6Power1.Checked == true)
                    {
                        name = rdoCharacter6Power1.Text;
                    }
                    else if (rdoCharacter6Power2.Checked == true)
                    {
                        name = rdoCharacter6Power2.Text;
                    }
                    else if (rdoCharacter6Power3.Checked == true)
                    {
                        name = rdoCharacter6Power3.Text;
                    }
                    break;
            }

            return name;
        }

        
        /// <summary>
        /// Set the lifes
        /// </summary>
        /// <param name="target">target character</param>
        /// <param name="life">Life of the character</param>
        public void MakeDamages(int target, int life)
        {
            // Set the life
            switch(target)
            {
                case 1:
                    SetLife(pgbTeamOneFighterOneLife, life);
                    break;
                case 2:
                    SetLife(pgbTeamOneFighterTwoLife, life);
                    break;
                case 3:
                    SetLife(pgbTeamOneFighterThreeLife, life);
                    break;
                case 4:
                    SetLife(pgbTeamTwoFighterOneLife, life);
                    break;
                case 5:
                    SetLife(pgbTeamTwoFighterTwoLife, life);
                    break;
                case 6:
                    SetLife(pgbTeamTwoFighterThreeLife, life);
                    break;
            }
        }

        /// <summary>
        /// Set the life of the progress bar
        /// </summary>
        /// <param name="progressBar">Progress bar</param>
        /// <param name="life">Life of the character</param>
        private void SetLife(ProgressBar progressBar, int life)
        {
            // Check if the life is upper than 0
            if(life > 0)
            {
                progressBar.Value = life;
            }
            else
            {
                progressBar.Value = 0;
            }
        }

        /// <summary>
        /// Set the actual turn
        /// </summary>
        /// <param name="name">name of the player</param>
        public void SetTurn(string name)
        {
            lblTurn.Text = $"Tour de {name}";
        }

        /// <summary>
        /// Close the page
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }
    }
}
