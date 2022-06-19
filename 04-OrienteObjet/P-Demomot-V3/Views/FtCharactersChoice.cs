using P_Demomot.Controllers;
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

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
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

        }


        //Team one

        private void pnlTeamOneCharacterOne_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamOneCharacterTwo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamOneCharacterThree_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamOneCharacterFour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamOneCharacterFive_Paint(object sender, PaintEventArgs e)
        {

        }

        //Team Two

        private void pnlTeamTwoCharacterOne_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamTwoCharacterTwo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamTwoCharacterThree_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamTwoCharacterFour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTeamTwoCharacterFive_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Hide the view
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }
    }
}
