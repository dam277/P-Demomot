using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.UserInfos;
using P_Demomot.Properties;
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
    public partial class ChestsView : Form, IView
    {
        private MainController _mainController;         // Main controller
        private ChestsController _chestController;         //chest controller
        private List<Chest> _chests;
        private List<Resources> _resources;

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public main controller
        /// </summary>
        public ChestsController ChestsController
        {
            get { return _chestController; }
            set { _chestController = value; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public ChestsView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChestsView_Load(object sender, EventArgs e)
        {
            _resources = new List<Resources>();
            //_resources.Add()
            //_chests = _chestController.GetAllChests();
        }

        /// <summary>
        /// Hide the view
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }

        private void pnlChest2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctNext_Click(object sender, EventArgs e)
        {
            
            Chest lastChest = _chests[_chests.Count() - 1];

            for(int i = _chests.Count() - 1; i >= 0; i--)
            {
                if(i > 0)
                {
                    _chests[i] = _chests[i - 1];
                }
                else
                {
                    _chests[i] = lastChest;
                }
            }
        }

        private void pctBack_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
