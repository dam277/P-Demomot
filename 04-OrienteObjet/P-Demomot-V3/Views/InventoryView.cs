using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Characters;
using P_Demomot.Models.Utils;
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
    public partial class InventoryView : Form, IView
    {
        #region Variables
        // CONTROLLERS
        private MainController _mainController;                 // Main controller
        private InventoryController _inventoryController;       // Inventory controller
        #endregion

        #region Getter Setter
        // CONTROLLERS
        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public inventory controller
        /// </summary>
        public InventoryController InventoryController
        {
            get { return _inventoryController; }
            set { _inventoryController = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        public InventoryView()
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
        private void InventoryView_Load(object sender, EventArgs e)
        {
            _inventoryController.DisplayFighters();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            _inventoryController.ShowMainMenu();
        }

        /// <summary>
        /// Open a message box with all the infos of the characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfos_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // Get the character
            Fighter fighter = _inventoryController.GetFighter(Convert.ToInt32(button.Name));

            // Get rarity
            Rarity rarity = _inventoryController.GetFighterRarity(fighter.Name);

            // Get the powers
            List<Power> powers = _inventoryController.GetPowers(fighter.IdCharacter);
            Power power1 = powers[0];
            Power power2 = powers[1];
            Power ultime;

            string message = $"Name : {fighter.Name} \n" +
                             $"Level : {fighter.Level} \n" +
                             $"Life : {fighter.Life} \n" +
                             $"Rarity : {rarity.Name} \n" +
                             $"Drop Chance : {rarity.DropChance} \n\n" +
                             $"Capacities : \n" +
                             $"Power 1 : {power1.Name} : \n" +
                             $"Capacity : {power1.Capacity} \n" +
                             $"Number of targets : {power1.NbTargets} \n" +
                             $"Number of turns affects : {power1.NbTurns} \n\n" +
                             $"Power 2 : {power2.Name} : \n" +
                             $"Capacity : { power2.Capacity} \n" +
                             $"Number of targets : {power2.NbTargets} \n" +
                             $"Number of turns affects : {power2.NbTurns} \n\n";

            if (fighter.Name != "Recruit")
            {
                ultime = powers[2];
                message += $"Ultime : {ultime.Name} : \n" +
                             $"Capacity : {ultime.Capacity} \n" +
                             $"Number of targets : {ultime.NbTargets} \n" +
                             $"Number of turns affects : {ultime.NbTurns} \n\n";
            }


            // Display the card
            MessageBox.Show(message);



        }
        #endregion

        #region Methods
        /// <summary>
        /// Display characters
        /// </summary>
        /// <param name="characters">Character</param>
        /// <param name="userCharacters">User characters</param>
        public void DisplayFighters(List<Fighter> characters, List<Fighter> userCharacters)
        {
            // Counter
            int counter = 0;

            // Display the characters
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    // TempFighter
                    Fighter tempFighter = new Fighter();
                    
                    // Color of the card
                    Color cardColor = Color.White;

                    // Size of the maximum characters
                    if (counter < 22)
                    {
                        tempFighter = characters[counter];

                        // Get the color of the rarity
                        if(tempFighter.Rarity.color == Color.Magenta)
                        {
                            cardColor = Color.Magenta;
                        }
                        else if(tempFighter.Rarity.color == Color.Gray)
                        {
                            cardColor = Color.Gray;
                        }
                        else if (tempFighter.Rarity.color == Color.Brown)
                        {
                            cardColor = Color.Brown;
                        }
                        else if (tempFighter.Rarity.color == Color.Green)
                        {
                            cardColor = Color.Green;
                        }
                        else if (tempFighter.Rarity.color == Color.Yellow)
                        {
                            cardColor = Color.Yellow;
                        }
                        else if (tempFighter.Rarity.color == Color.Blue)
                        {
                            cardColor = Color.Blue;
                        }
                        else if (tempFighter.Rarity.color == Color.Purple)
                        {
                            cardColor = Color.Purple;
                        }
                        else if (tempFighter.Rarity.color == Color.Red)
                        {
                            cardColor = Color.Red;
                        }

                        //Creation of the cards
                        Panel pnlCards = new Panel();
                        pnlCards.Height = 125;
                        pnlCards.Width = 125;

                        pnlCards.Top = pnlCards.Height * y + 15 + (y * 30);
                        pnlCards.Left = pnlCards.Width * x + 15 + (x * 30);

                        pnlCards.BackColor = cardColor;
                        pnlCards.BorderStyle = BorderStyle.FixedSingle;

                        //add the cards to the panel
                        pnlInventory.Controls.Add(pnlCards);

                        // Creation of texts
                        // name of the character
                        Label name = new Label();
                        name.Text = tempFighter.Name;

                        pnlCards.Controls.Add(name);

                        //Check if the fighter exists
                        foreach(Fighter userFighter in userCharacters)
                        {
                            if(userFighter.Name == tempFighter.Name)
                            {
                                Button button = new Button();
                                button.Name = userFighter.IdCharacter.ToString();
                                button.Text = "Infos";
                                button.BackColor = Color.White;
                                button.Height = 50;
                                button.Width = pnlCards.Width / 2;
                                button.Top = 50;
                                button.Left = pnlCards.Width / 2 - button.Width / 2;
                                button.Click += new EventHandler(btnInfos_Click);
                                pnlCards.Controls.Add(button);
                            }
                        }
                    }
                    counter++;
                }
            }
        }

        /// <summary>
        /// Hide the view
        /// </summary>
        public void CloseView()
        {
            this.Hide();
        }
        #endregion

        /// <summary>
        /// Display characters on visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryView_VisibleChanged(object sender, EventArgs e)
        {
            pnlInventory.Controls.Clear();
            _inventoryController.DisplayFighters();
        }
    }
}
