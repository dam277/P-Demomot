using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.Game
{
    public class PlayController : MainController
    {
        // CONTROLLERS
        private MainController _mainController;         // Main controller

        // VIEWS
        private PlayView _playView;                     // play view

        // MODELS

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Public play view
        /// </summary>
        public PlayView PlayView
        {
            get { return _playView; }
            set { _playView = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playView">play view</param>
        public PlayController(PlayView playView)
        {
            _playView = playView;
            _playView.PlayController = this;
        }

        /// <summary>
        /// Show Fight tactics character choice
        /// </summary>
        public void ShowFtCharacterChoice()
        {
            _mainController.ShowView(Action.FTCHARACHOICE, _playView);
        }

        /// <summary>
        /// Show main menu
        /// </summary>
        public void ShowMainMenu()
        {
            _mainController.ShowView(Action.MAINMENU, _playView);
        }
    }
}
