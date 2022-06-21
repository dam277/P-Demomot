using P_Demomot.Models.UserInfos;
using P_Demomot.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Controllers.UserProperties
{
    public class ChestsController : MainController
    {
        #region Variables
        private MainController _mainController;         // Main controller
        private ChestsView _chestsView;                 // Chest view
        private Chest _chest;                           // Chest model
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
        /// Public chest view
        /// </summary>
        public ChestsView ChestsView
        {
            get { return _chestsView; }
            set { _chestsView = value; }
        }

        /// <summary>
        /// Public chest model
        /// </summary>
        public Chest Chest
        {
            get { return _chest; }
            set { _chest = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="chestsView">chest view</param>
        /// <param name="chest">chest model</param>
        public ChestsController(ChestsView chestsView, Chest chest)
        {
            _chest = chest;
            _chestsView = chestsView;
            _chest.ChestsController = this;
            _chestsView.ChestsController = this;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get all the chests
        /// </summary>
        /// <returns>Return a list of chests</returns>
        public List<Chest> GetAllChests()
        {
            return _chest.GetAllChests();
        }
        #endregion
    }
}
