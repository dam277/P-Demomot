using P_Demomot.Models.UserInfos;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Demomot.Controllers.Menus
{
    public class MainMenuController : MainController
    {
        #region Variables
        // CONTROLLERS
        private MainController _mainController;         // Main controller

        // VIEWS
        private MainMenuView _mainMenuView;             // Main menu view

        // MODELS
        private User _user;                             // User model
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

        // VIEWS
        /// <summary>
        /// Public main menu view
        /// </summary>
        public MainMenuView MainMenuView
        {
            get { return _mainMenuView; }
            set { _mainMenuView = value; }
        }

        // MODELS
        /// <summary>
        /// Public user model
        /// </summary>
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="mainMenuView">Main menu view</param>
        /// <param name="user">User model</param>
        public MainMenuController(MainMenuView mainMenuView, User user)
        {
            _mainMenuView = mainMenuView;
            _user = user;
            _mainMenuView.MainMenuController = this;
            _user.MainMenuController= this;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get the nickname of the user
        /// </summary>
        /// <returns>Return the nickname of the user</returns>
        public string GetNickname()
        {
            return _user.Nickname;
        }

        /// <summary>
        /// Get the rank of the user
        /// </summary>
        /// <returns>Return a rank</returns>
        public Dictionary<string, string> GetRank()
        {
            Dictionary<string, string> rank = new Dictionary<string, string>();
            rank.Add("name", _user.Rank.Name);
            rank.Add("points", _user.Rank.Points.ToString());

            return rank;
        }

        /// <summary>
        /// Disconnect the user
        /// </summary>
        public void DisconnectUser()
        {
            Application.Restart();
        }

        /// <summary>
        /// Show the inventory
        /// </summary>
        public void ShowInventory()
        {
            ShowView(Action.INVENTORY);
        }

        /// <summary>
        /// Show the play view
        /// </summary>
        public void ShowPlay()
        {
            ShowView(Action.PLAY);
        }

        /// <summary>
        /// Show the play view
        /// </summary>
        public void ShowChests()
        {
            ShowView(Action.CHESTS);
        }

        /// <summary>
        /// Show a view
        /// </summary>
        /// <param name="action">Action</param>
        private void ShowView(Action action)
        {
            _mainController.ShowView(action, _mainMenuView);
        }
        #endregion
    }
}
