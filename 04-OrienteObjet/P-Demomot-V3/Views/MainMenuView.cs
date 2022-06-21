using P_Demomot.Controllers;
using P_Demomot.Controllers.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Demomot.Controllers;

namespace P_Demomot.Views
{
    public partial class MainMenuView : Form, IView
    {
        #region Variables
        // CONTROLLERS
        private MainController _mainController;         // Main controller
        private MainMenuController _mainMenuController; // Main menu controller
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public main menu controller
        /// </summary>
        public MainMenuController MainMenuController
        {
            get { return _mainMenuController; }
            set { _mainMenuController = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        public MainMenuView()
        {
            InitializeComponent();
        }
        #endregion

        #region Elements Methods
        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuView_Load(object sender, EventArgs e)
        {
            lblNickname.Text += " " + _mainMenuController.GetNickname();
            Dictionary<string, string> rank = _mainMenuController.GetRank();
            lblGradeName.Text += " " + rank["name"];
            lblGradePoints.Text += " " + rank["points"];
        }

        /// <summary>
        /// Go to the inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            _mainMenuController.ShowInventory();
        }

        private void btnModifyAccount_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Disconnect the user
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event</param>
        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            _mainMenuController.DisconnectUser();
        }

        /// <summary>
        /// Open the play window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            _mainMenuController.ShowPlay();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Quit the application
        /// </summary>
        /// <param name="sender">Sender obkject</param>
        /// <param name="e">Event</param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnGradeTb_Click(object sender, EventArgs e)
        {

        }

        private void btnGradeFt_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show the chest page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChests_Click(object sender, EventArgs e)
        {
            _mainMenuController.ShowChests();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Hide the view
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }
        #endregion

        
    }
}
