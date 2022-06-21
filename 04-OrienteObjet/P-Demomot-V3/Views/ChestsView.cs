using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Characters;
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
        private List<Bitmap> _chestImages;
        private List<string> _names;

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
            // Set the list of chests
            _chestImages = new List<Bitmap>();
            _chestImages.Add(Resources.magicChest);
            _chestImages.Add(Resources.oldChest);
            _chestImages.Add(Resources.reinforcedChest);
            _chestImages.Add(Resources.brightChest);
            _chestImages.Add(Resources.royalChest);
            _chestImages.Add(Resources.diamondChest);

            _names = new List<string>();
            _names.Add("Magical chest");
            _names.Add("Old box");
            _names.Add("Reinforced chest");
            _names.Add("Bright chest");
            _names.Add("Royal chest");
            _names.Add("Diamond chest");

            CheckNbrChests();
        }

        /// <summary>
        /// Check the nbr of chest the user have
        /// </summary>
        private void CheckNbrChests()
        {
            // Get all the chests of the user
            Dictionary<string, List<Chest>> chests = _chestController.GetAllUserChests();

            // Get the number of boxes
            foreach (string name in chests.Keys)
            {
                if (name == _names[1])
                {
                    lblNbrChests.Text = chests[name].Count().ToString();
                    break;
                }
                lblNbrChests.Text = "0";
            }
        }

        /// <summary>
        /// Hide the view
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }


        /// <summary>
        /// Next chest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctNext_Click(object sender, EventArgs e)
        {
            // Set a variable to have the book which will move to the other side of the array
            Bitmap lastChest = _chestImages[0];
            string name = _names[0];

            // Exchange the places of the table by 1 to the left
            for (int i = 0; i < _chestImages.Count(); i++)
            {
                if (i < _chestImages.Count() - 1)
                {
                    _chestImages[i] = _chestImages[i + 1];
                    _names[i] = _names[i + 1];
                }
                else
                {
                    _chestImages[i] = lastChest;
                    _names[i] = name;
                }
            }

            // Set the panels
            pnlChest1.BackgroundImage = _chestImages[0];
            pnlChest2.BackgroundImage = _chestImages[1];
            pnlChest3.BackgroundImage = _chestImages[2];

            CheckNbrChests();
        }

        /// <summary>
        /// Back chest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctBack_Click(object sender, EventArgs e)
        {
            // Set a variable to have the book which will move to the other side of the array
            Bitmap lastChest = _chestImages[_chestImages.Count() - 1];
            string name = _names[_names.Count() - 1];

            // Exchange the places of the table by 1 to the left
            for (int i = _chestImages.Count() - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    _chestImages[i] = _chestImages[i - 1];
                    _names[i] = _names[i - 1];
                }
                else
                {
                    _chestImages[i] = lastChest;
                    _names[i] = name;
                }
            }

            // Set the panels
            pnlChest1.BackgroundImage = _chestImages[0];
            pnlChest2.BackgroundImage = _chestImages[1];
            pnlChest3.BackgroundImage = _chestImages[2];

            CheckNbrChests();
        }

        /// <summary>
        /// Show main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            _chestController.ShowMainMenu();
        }

        /// <summary>
        /// Show the character recieved
        /// </summary>
        /// <param name="fighter"></param>
        public void ShowCharacter(Fighter fighter)
        {
            MessageBox.Show($"Name : {fighter.Name}");
        }

        /// <summary>
        /// Open the chest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlChest2_Click(object sender, EventArgs e)
        {
            // Open the chest
            _chestController.OpenChest(_names[1]);

            // Check the number of chest
            CheckNbrChests();
        }
    }
}
