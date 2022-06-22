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
    public partial class FtCharactersChoiceInventory : Form
    {
        private MainController _mainController;         // Main controller
        private FtCharactersChoiceController _ftCharactersChoiceController;         // Main controller

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public character choice controller
        /// </summary>
        public FtCharactersChoiceController FtCharactersChoiceController
        {
            get { return _ftCharactersChoiceController; }
            set { _ftCharactersChoiceController = value; }
        }

        public FtCharactersChoiceInventory()
        {
            InitializeComponent();
        }

        private void FtCharactersChoiceInventory_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FtCharactersChoiceInventory_VisibleChanged(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.DisplayFighters();
        }

        /// <summary>
        /// Display the fighters of the user
        /// </summary>
        /// <param name="fighters">List of fighters</param>
        public void DisplayFighters(List<Fighter> fighters)
        {
            pnlBorder.Controls.Clear();

            int counter = 0;
            // Display the characters
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    if (counter < fighters.Count())
                    {
                        //Creation of the cards
                        Panel pnlCards = new Panel();
                        pnlCards.Name = fighters[counter].Name;
                        pnlCards.Height = 125;
                        pnlCards.Width = 125;

                        pnlCards.Top = pnlCards.Height * y + 15 + (y * 30);
                        pnlCards.Left = pnlCards.Width * x + 15 + (x * 30);

                        pnlCards.BorderStyle = BorderStyle.FixedSingle;
                        pnlCards.Click += new EventHandler(pnlCards_click);

                        //add the cards to the panel
                        pnlBorder.Controls.Add(pnlCards);

                        Label label = new Label();
                        label.Text = fighters[counter].Name;
                        label.ForeColor = Color.White;

                        pnlCards.Controls.Add(label);
                    }
                    counter++;
                }
            }
        }

        /// <summary>
        /// Click on the card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlCards_click(object sender, EventArgs e)
        {
            _ftCharactersChoiceController.AddFighterToTeam((sender as Panel).Name);
            this.Hide();
        }
    }
}
