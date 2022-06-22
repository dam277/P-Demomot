using P_Demomot.Controllers;
using P_Demomot.Controllers.FightTactics;
using P_Demomot.Models.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Demomot.Views
{
    public partial class FtCharactersChoice : Form, IView
    {

        private MainController _mainController;         // Main controller
        private FtCharactersChoiceController _ftCharactersChoiceController;         // character choice controller
        private bool doReset = false;               // Do a reset variable

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        public FtCharactersChoiceController FtCharactersChoiceController
        {
            get { return _ftCharactersChoiceController; }
            set { _ftCharactersChoiceController = value; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public FtCharactersChoice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FtCharactersChoice_Load(object sender, EventArgs e)
        {
            // Get the name of the host
            lblTeamOfHost.Text += _ftCharactersChoiceController.GetUserName();

            // Create the teams
            _ftCharactersChoiceController.CreateTeams();
        }

        /// <summary>
        /// Hide the view
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }

        //Team one
        /// <summary>
        /// Panel of the first character of the first team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamOneCharacterOne_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ChoseCharacter(1);
        }

        /// <summary>
        /// Panel of the second character of the first team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamOneCharacterTwo_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ChoseCharacter(1);
        }

        /// <summary>
        /// Panel of the third character of the first team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamOneCharacterThree_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ChoseCharacter(1);
        }

        //Team Two
        /// <summary>
        /// Panel of the first character of the second team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamTwoCharacterOne_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ChoseCharacter(2);
        }

        /// <summary>
        /// Panel of the second character of the second team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamTwoCharacterTwo_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ChoseCharacter(2);
        }

        /// <summary>
        /// Panel of the third character of the second team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTeamTwoCharacterThree_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ChoseCharacter(2);
        }

        /// <summary>
        /// Display text
        /// </summary>
        /// <param name="panel">Panel sender</param>
        /// <param name="fighter">Fighter chosed</param>
        public void DisplayText(int panelNbr, Fighter fighter)
        {
            // Create the name label 
            Label name = new Label();
            name.Text = "Name : " + fighter.Name;
            name.ForeColor = Color.White;

            // Write to the panel
            switch(panelNbr)
            {
                case 1:
                    pnlTeamOneCharacterOne.Controls.Add(name);
                    break;
                case 2:
                    pnlTeamOneCharacterTwo.Controls.Add(name);
                    break;
                case 3:
                    pnlTeamOneCharacterThree.Controls.Add(name);
                    break;
                case 4:
                    pnlTeamTwoCharacterOne.Controls.Add(name);
                    break;
                case 5:
                    pnlTeamTwoCharacterTwo.Controls.Add(name);
                    break;
                case 6:
                    pnlTeamTwoCharacterThree.Controls.Add(name);
                    break;
            }
        }

        /// <summary>
        /// Validate the choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.ShowGame();
        }

        /// <summary>
        /// At visible changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FtCharactersChoice_VisibleChanged(object sender, EventArgs e)
        {
            // Get the name of the host
            lblTeamOfHost.Text += _ftCharactersChoiceController.GetUserName();

            // Create the teams
            _ftCharactersChoiceController.CreateTeams();

            // Reset the characters
            foreach (Control control in pnlTeamOne.Controls)
            {
                control.Controls.Clear();
            }

            foreach (Control control in pnlTeamTwo.Controls)
            {
                control.Controls.Clear();
            }
        }
    }
}
