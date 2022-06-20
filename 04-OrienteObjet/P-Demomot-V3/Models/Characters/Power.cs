using P_Demomot.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Characters
{
    public class Power
    {
        #region Variables
        private MainController _mainController;         // Main controller
        private string _name;                           // Power name
        private string _description;                    // Power description
        private string _capacity;                         // Power damages
        private int _loadTurns;                         // Power turns to use it
        private int _nbTurns;                           // Power number of turns damages
        private int _percentage;                        // Ultime Power percentage
        private int _percentageUpPerHit;                // Ultime Power percentage up per hit
        private int _percentageUpPerKill;               // Ultime Power percentage up per kill
        private bool _isUltime;                         // Define if the power is an Ultime
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get
            {
                return _mainController;
            }
            set
            {
                _mainController = value;
            }
        }

        /// <summary>
        /// Public power name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Public power description
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
        }

        /// <summary>
        /// Public power damages
        /// </summary>
        public string Damages
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        /// <summary>
        /// Public power load turns
        /// </summary>
        public int LoadTurns
        {
            get
            {
                return _loadTurns;
            }
        }

        /// <summary>
        /// Public power number turns
        /// </summary>
        public int NbTurns
        {
            get
            {
                return _nbTurns;
            }
        }

        /// <summary>
        /// Public power percentage
        /// </summary>
        public int Percentage
        {
            get
            {
                return _percentage;
            }
            set
            {
                _percentage = value;
            }
        }

        /// <summary>
        /// Public power percentage up per hit
        /// </summary>
        public int PercentageUpPerHit
        {
            get
            {
                return _percentageUpPerHit;
            }
        }

        /// <summary>
        /// Public power percentage up per kill
        /// </summary>
        public int PercentageUpPerKill
        {
            get
            {
                return _percentageUpPerKill;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Power()
        {

        }

        /// <summary>
        /// Model of power class constructor
        /// </summary>
        public Power(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Normal power class constructor
        /// </summary>
        /// <param name="name">Power name</param>
        /// <param name="description">Power description</param>
        /// <param name="damages">Power damages</param>
        /// <param name="loadTurns">Power turns to use it</param>
        /// <param name="nbTurns">Power number of turns damages</param>
        public Power(string name, string description, string damages, int loadTurns, int nbTurns)
        {
            _name = name;
            _description = description;
            _capacity = damages;
            _loadTurns = loadTurns;
            _nbTurns = nbTurns;
            _isUltime = false;
        }

        /// <summary>
        /// Ultime power class constructor
        /// </summary>
        /// <param name="name">Power name</param>
        /// <param name="description">Power description</param>
        /// <param name="damages">Power damages</param>
        /// <param name="percentageUpPerHit">Ultime Power percentage up per hit</param>
        /// <param name="percentageUpPerKill">Ultime Power percentage up per kill</param>
        /// <param name="nbTurns">Power number of turns damages</param>
        public Power(string name, string description, string damages, int percentageUpPerHit, int percentageUpPerKill, int nbTurns)
        {
            _name = name;
            _description = description;
            _capacity = damages;
            _percentage = 0;
            _percentageUpPerHit = percentageUpPerHit;
            _percentageUpPerKill = percentageUpPerKill;
            _nbTurns = nbTurns;
            _isUltime = true;
        }
        #endregion

        #region Methods
        #endregion
    }
}
