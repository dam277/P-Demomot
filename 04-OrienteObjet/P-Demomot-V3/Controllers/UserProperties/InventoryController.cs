using P_Demomot.Models.Characters;
using P_Demomot.Models.UserInfos;
using P_Demomot.Models.Utils;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.UserProperties
{
    public class InventoryController : MainController
    {
        #region Variables
        // CONTROLLERS
        private MainController _mainController;         // Main controller

        // MODELS
        private User _user;                             // User model
        private Fighter _fighter;                       // Fighter model
        private Power _power;                       // Fighter model

        // VIEWS
        private InventoryView _inventoryView;           // Inventory view
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
        /// Public main controller
        /// </summary>
        public InventoryView InventoryView
        {
            get { return _inventoryView; }
            set { _inventoryView = value; }
        }

        /// <summary>
        /// Public user Model
        /// </summary>
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        /// <summary>
        /// Public user Model
        /// </summary>
        public Power Power
        {
            get { return _power; }
            set { _power = value; }
        }

        /// <summary>
        /// Public fighter Model
        /// </summary>
        public Fighter Fighter
        {
            get { return _fighter; }
            set { _fighter = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="inventoryView">Inventory view</param>
        /// <param name="user">User model</param>
        /// <param name="fighter">fighter model</param>
        public InventoryController(InventoryView inventoryView, User user, Fighter fighter, Power power)
        {
            _inventoryView = inventoryView;
            _user = user;
            _fighter = fighter;
            _power = power;
            _inventoryView.InventoryController = this;
            _user.InventoryController = this;
            _fighter.InventoryController = this;
            _power.InventoryController = this;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Display the fighters
        /// </summary>
        public void DisplayFighters()
        {
            _inventoryView.DisplayFighters(_fighter.FightersList, _user.FighterList);
        }

        /// <summary>
        /// Get the powers
        /// </summary>
        /// <returns>Return the powers</returns>
        public List<Power> GetPowers(int idCharacter)
        {
            return _power.GetPowers(idCharacter);
        }

        /// <summary>
        /// Get the fighter
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return a fighter</returns>
        public Fighter GetFighter(int id)
        {
            // Search the fighter
            foreach(Fighter fighter in _user.FighterList)
            {
                if(fighter.IdCharacter == id)
                {
                    return fighter;
                }
            }

            return null;
        }

        /// <summary>
        /// Get the rarity of the fighter
        /// </summary>
        /// <param name="name">Name of the fighter</param>
        /// <returns>Return a rarity</returns>
        public Rarity GetFighterRarity(string name)
        {
            // Search the fighter
            foreach (Fighter fighter in _fighter.FightersList)
            {
                if (fighter.Name == name)
                {
                    return fighter.Rarity;
                }
            }

            return null;
        }

        /// <summary>
        /// Show the main menu
        /// </summary>
        public void ShowMainMenu()
        {
            _mainController.ShowView(Action.MAINMENU, _inventoryView);
        }
        #endregion
    }
}
