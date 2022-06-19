using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Databases;
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
    public partial class LoginSignInView : Form, IView
    {
        private MainController _mainController;                     // Main controller
        private LoginSignInController _loginSignInController;       // Login controller

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public login controller
        /// </summary>
        public LoginSignInController LoginSignInController
        {
            get { return _loginSignInController; }
            set { _loginSignInController = value; }
        }

        /// <summary>
        /// CLass constructor
        /// </summary>
        public LoginSignInView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginSignInView_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click of the button to validate to create an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInscriptionValidate_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Click of button to validate to connect to an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnectionValidate_Click(object sender, EventArgs e)
        {
            _loginSignInController.ConnectToUser(txtConnectionNickname.Text, txtConnectionPassword.Text);
        }

        /// <summary>
        /// Show an error message
        /// </summary>
        /// <param name="message"></param>
        public void ShowConnectionErros(string message)
        {
            lblConnectionErrors.Text = message;
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
