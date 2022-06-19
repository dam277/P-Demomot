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
    public partial class GameTypeView : Form, IView
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
        public GameTypeView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTypeView_Load(object sender, EventArgs e)
        {

        }

        private void btnLocal_Click(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnVsIa_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void GameTypeView_Load_1(object sender, EventArgs e)
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
