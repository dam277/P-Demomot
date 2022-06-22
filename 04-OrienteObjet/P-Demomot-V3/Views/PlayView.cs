using P_Demomot.Controllers;
using P_Demomot.Controllers.Game;
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
    public partial class PlayView : Form, IView
    {
        private MainController _mainController;         // Main controller
        private PlayController _playController;         // Play controller

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public play controller
        /// </summary>
        public PlayController PlayController
        {
            get { return _playController; }
            set { _playController = value; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public PlayView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Play view load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayView_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show the TankBattle page character choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayTb_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Show fight tactics page character choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayFt_Click(object sender, EventArgs e)
        {
            _playController.ShowFtCharacterChoice();
        }

        /// <summary>
        /// Return to the page Main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            _playController.ShowMainMenu();
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
