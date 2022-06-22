using P_Demomot.Controllers.FightTactics;
using P_Demomot.Controllers.Game;
using P_Demomot.Controllers.Menus;
using P_Demomot.Controllers.TankBattle;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Characters;
using P_Demomot.Models.UserInfos;
using P_Demomot.Models.Utils;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers
{
    public class MainController
    {
        protected LoginSignInView _loginSignInView;                             // Login signIn view
        protected ChestsView _chestsView;                                       // Chest view
        protected FtCharactersChoice _ftCharactersChoice;                       // Ft character choice view
        protected FtGameView _ftGameView;                                       // Ft game view
        protected InventoryView _inventoryView;                                 // Inventory view
        protected MainMenuView _mainMenuView;                                   // Main menu view
        protected PlayView _playView;                                           // Play view
        protected TbCharactersChoice _tbCharactersChoice;                       // Tb character choice view
        protected TbGameView _tbGameView;                                       // Tb game view
        protected FtCharactersChoiceInventory _ftCharactersChoiceInventory;     // Ft character inventory view

        private FtCharactersChoiceController _ftCharactersChoiceController;     // Ft character choice controller
        private FtGameController _ftGameController;                             // Ft game controller
        private PlayController _playController;                                 // Play controller
        private MainMenuController _mainMenuController;                         // Main menu controller
        private TbCharactersChoiceController _tbCharactersChoiceController;     // Tb Character choice controller
        private TbGameController _tbGameController;                             // Tb game controller
        private ChestsController _chestsController;                             // Chests controller
        private InventoryController _inventoryController;                       // Inventory controller
        private LoginSignInController _loginSignInController;                   // Login sign in controller

        /// <summary>
        /// Basic class constructor
        /// </summary>
        public MainController()
        {

        }

        /// <summary>
        /// Main controller class constructor
        /// </summary>
        /// <param name="loginSignInView">Login signIn view</param>
        /// <param name="chestsView">Chest view</param>
        /// <param name="ftCharactersChoice">Ft character choice view</param>
        /// <param name="ftGameView">Ft game view</param>
        /// <param name="inventoryView">Inventory view</param>
        /// <param name="mainMenuView">Main menu view</param>
        /// <param name="playView">Play view</param>
        /// <param name="tbCharactersChoice">Tb character choice view</param>
        /// <param name="tbGameView">Tb game view</param>
        /// <param name="ftCharactersChoiceController">Ft character choice controller</param>
        /// <param name="ftGameController">Ft game controller</param>
        /// <param name="playController">Play controller</param>
        /// <param name="mainMenuController">Main menu controller</param>
        /// <param name="tbCharactersChoiceController">Tb Character choice controller</param>
        /// <param name="tbGameController">Chests controller</param>
        /// <param name="chestsController">Inventory controller</param>
        /// <param name="inventoryController"></param>
        /// <param name="loginSignInController">Login sign in controller</param>
        public MainController(LoginSignInView loginSignInView, ChestsView chestsView, FtCharactersChoice ftCharactersChoice, FtGameView ftGameView,
            InventoryView inventoryView, MainMenuView mainMenuView, PlayView playView, TbCharactersChoice tbCharactersChoice, TbGameView tbGameView,
            FtCharactersChoiceController ftCharactersChoiceController, FtGameController ftGameController, PlayController playController,
            MainMenuController mainMenuController, TbCharactersChoiceController tbCharactersChoiceController, TbGameController tbGameController,
            ChestsController chestsController, InventoryController inventoryController, LoginSignInController loginSignInController, FtCharactersChoiceInventory ftCharactersChoiceInventory)
        {
            // Set the views
            _loginSignInView = loginSignInView;
            _chestsView = chestsView;
            _ftCharactersChoice = ftCharactersChoice;
            _ftGameView = ftGameView;
            _inventoryView = inventoryView;
            _mainMenuView = mainMenuView;
            _playView = playView;
            _tbCharactersChoice = tbCharactersChoice;
            _tbGameView = tbGameView;
            _ftCharactersChoiceInventory = ftCharactersChoiceInventory;

            // Set main controller into views
            _loginSignInView.MainController = this;
            _chestsView.MainController = this;
            _ftCharactersChoice.MainController = this;
            _ftGameView.MainController = this;
            _inventoryView.MainController = this;
            _mainMenuView.MainController = this;
            _playView.MainController = this;
            _tbCharactersChoice.MainController = this;
            _tbGameView.MainController = this;
            _ftCharactersChoiceInventory.MainController = this;

            // Set the controllers
            _ftCharactersChoiceController = ftCharactersChoiceController;
            _ftGameController = ftGameController;
            _playController = playController;
            _mainMenuController = mainMenuController;
            _tbCharactersChoiceController = tbCharactersChoiceController;
            _tbGameController = tbGameController;
            _chestsController = chestsController;
            _inventoryController = inventoryController;
            _loginSignInController = loginSignInController;

            // Set main controller in other controllers
            _ftCharactersChoiceController.MainController = this;
            _ftGameController.MainController = this;
            _playController.MainController = this;
            _mainMenuController.MainController = this;
            _tbCharactersChoiceController.MainController = this;
            _tbGameController.MainController = this;
            _tbGameController.MainController = this;
            _chestsController.MainController = this;
            _inventoryController.MainController = this;
            _loginSignInController.MainController = this;
        }

        /// <summary>
        /// Show a view while closing the opened one
        /// </summary>
        /// <param name="action">Action of the operation (view to open)</param>
        public void ShowView(Action action, IView view)
        {
            // Close the actual view
            view.CloseView();

            // Show the new view
            switch(action)
            {
                case Action.CHESTS:
                    _chestsView.Show();
                    break;
                case Action.FTCHARACHOICE:
                    _ftCharactersChoice.Show();
                    break;
                case Action.FTGAME:
                    _ftGameView.Show();
                    break;
                case Action.INVENTORY:
                    _inventoryView.Show();
                    break;
                case Action.LOGINSIGNIN:
                    _loginSignInView.Show();
                    break;
                case Action.MAINMENU:
                    _mainMenuView.Show();
                    break;
                case Action.PLAY:
                    _playView.Show();
                    break;
                case Action.TBCHARACHOICE:
                    _tbCharactersChoice.Show();
                    break;
                case Action.TBGAME:
                    _tbGameView.Show();
                    break;
                case Action.FtInventory:
                    _ftCharactersChoiceInventory.Show();
                    break;
                    
            }
        }
    }
}
