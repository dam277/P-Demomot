﻿using Newtonsoft.Json.Linq;
using P_Demomot.Controllers;
using P_Demomot.Controllers.FightTactics;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Databases;
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
        // CONTROLLERS
        private MainController _mainController;         // Main controller
        private LoginSignInController _loginController; // Login controller
        private ChestsController _chestsController;     // chest controller
        private InventoryController _inventoryController;// inventory controller
        private FtCharactersChoiceController _ftCharactersChoiceController;// character choice controller
        private FtGameController _ftGameController;// game controller

        // CLASS VARIABLES
        private string _name;                           // Power name
        private string _description;                    // Power description
        private string _capacity;                       // Power capacity
        private int _nbTargets;                         // Power number of targets
        private int _loadTurns;                         // Power turns to use it
        private int _nbTurns;                           // Power number of turns damages
        private int _percentage;                        // Ultime Power percentage
        private int _percentageUpPerHit;                // Ultime Power percentage up per hit
        private int _percentageUpPerKill;               // Ultime Power percentage up per kill
        private bool _isUltime;                         // Define if the power is an Ultime

        // REQUESTS VARIABLES
        private Dictionary<string, string> _binds;              // Dictionary of binds to the requests
        private List<string> _columns;                          // Columns searched in the request
        #endregion

        #region Getter Setter
        // CONTROLLERS
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
        /// Public login signin controller
        /// </summary>
        public LoginSignInController loginSignInController
        {
            get
            {
                return _loginController;
            }
            set
            {
                _loginController = value;
            }
        }

        /// <summary>
        /// Public chest controller
        /// </summary>
        public ChestsController ChestsController
        {
            get
            {
                return _chestsController;
            }
            set
            {
                _chestsController = value;
            }
        }

        /// <summary>
        /// Public inventory controller
        /// </summary>
        public InventoryController InventoryController
        {
            get
            {
                return _inventoryController;
            }
            set
            {
                _inventoryController = value;
            }
        }

        /// <summary>
        /// Public character choice controller
        /// </summary>
        public FtCharactersChoiceController FtCharactersChoiceController
        {
            get
            {
                return _ftCharactersChoiceController;
            }
            set
            {
                _ftCharactersChoiceController = value;
            }
        }

        /// <summary>
        /// Public character choice controller
        /// </summary>
        public FtGameController FtGameController
        {
            get
            {
                return _ftGameController;
            }
            set
            {
                _ftGameController = value;
            }
        }

        // CLASS VARIABLES
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
        public string Capacity
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
        public int NbTargets
        {
            get
            {
                return _nbTargets;
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

        /// <summary>
        /// Public power is ultime
        /// </summary>
        public bool IsUltime
        {
            get
            {
                return _isUltime;
            }
            set
            {
                _isUltime = value;
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
        /// <param name="capacity">Power damages</param>
        /// <param name="loadTurns">Power turns to use it</param>
        /// <param name="nbTurns">Power number of turns damages</param>
        public Power(string name, string description, string capacity, int loadTurns, int nbTurns, int nbTargets)
        {
            _name = name;
            _description = description;
            _capacity = capacity;
            _loadTurns = loadTurns;
            _nbTurns = nbTurns;
            _nbTargets = nbTargets;
            _isUltime = false;
        }

        /// <summary>
        /// Ultime power class constructor
        /// </summary>
        /// <param name="name">Power name</param>
        /// <param name="description">Power description</param>
        /// <param name="capacity">Power damages</param>
        /// <param name="percentageUpPerHit">Ultime Power percentage up per hit</param>
        /// <param name="percentageUpPerKill">Ultime Power percentage up per kill</param>
        /// <param name="nbTurns">Power number of turns damages</param>
        public Power(string name, string description, string capacity, int percentageUpPerHit, int percentageUpPerKill, int nbTurns, int nbTargets)
        {
            _name = name;
            _description = description;
            _capacity = capacity;
            _percentage = 0;
            _percentageUpPerHit = percentageUpPerHit;
            _percentageUpPerKill = percentageUpPerKill;
            _nbTurns = nbTurns;
            _nbTargets = nbTargets;
            _isUltime = true;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Create a power for a character
        /// </summary>
        /// <param name="characterName">Name of the character</param>
        /// <param name="powerName">Name of the power</param>
        /// <returns>Return a new power</returns>
        public Power CreatePower(string characterName, string powerName, int characterLevel)
        {
            // Get the name of the level
            string levelName = GetLevelName(characterLevel);

            // Get the capacity of a power
            string capacity = JToken.Parse(GetPowerCapacity(powerName, levelName)).ToString();

            // Get the load turns of a power
            int nbLoadTurns = GetPowerNbLoadTurns(powerName);

            // Get the number of turns the power affects his target
            int nbTurns = GetPowerNbTurns(powerName);

            // Get the numbet of targets of the power
            int nbTargets = GetPowerTargets(powerName);

            // Get the id of the character
            int idCharacter = _loginController.GetCharacterId(characterName);

            // Create the power
            Power power = new Power(JToken.Parse(powerName).ToString(), "", capacity, nbLoadTurns, nbTurns, nbTargets);

            // Insert the power into the database
            InsertPower(power, idCharacter);

            // Return the power
            return power;
        }

        /// <summary>
        /// Upgrade a power
        /// </summary>
        /// <param name="characterLevel">character level</param>
        /// <param name="idCharacter">Character id</param>
        public void Upgrade(int characterLevel, int idCharacter, string characterName)
        {
            // Update a power
            // Request
            string req = $"UPDATE t_power SET powCapacity = @powCapacity WHERE idPower = @idPower";

            // Get the life of the character
            string capacity = JToken.Parse(GetCapacity(characterLevel, characterName, this.Name)).ToString();

            // Get power Id
            int id = GetPowerId(this.Name, idCharacter);

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@powCapacity", capacity);
            _binds.Add("@idPower", id.ToString());

            // Execute query
            Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);
        }

        /// <summary>
        /// Get a cpacity
        /// </summary>
        /// <returns>Return a capacity</returns>
        private string GetCapacity(int level, string characterName, string powerName)
        {
            // Get the level name
            string levelname = GetLevelName(level);

            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.{levelname}' AS 'Capacity' FROM t_upgrade WHERE upgCharacterName = @characterName";

            //Columns name
            _columns = new List<string>();
            _columns.Add("Capacity");

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@characterName", characterName);

            return Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0];
        }

        /// <summary>
        /// Get the power Id
        /// </summary>
        /// <param name="powerName">Power name</param>
        /// <returns>Return the power id</returns>
        public int GetPowerId(string powerName, int idCharacter)
        {
            // Request
            string req = $"SELECT idPower FROM t_power WHERE powName = @powName AND idCharacter = @idCharacter";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@powName", powerName);
            _binds.Add("@idCharacter", idCharacter.ToString());

            //Columns name
            _columns = new List<string>();
            _columns.Add("idPower");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // Return the id
            return Convert.ToInt32(datas[0][0]);
        }

        /// <summary>
        /// Get the name of the level
        /// </summary>
        /// <param name="level">level</param>
        /// <returns>Return the name of the level</returns>
        private string GetLevelName(int level)
        {
            string levelName = "";

            // Get the level name
            switch (level)
            {
                case 1:
                    levelName = "levelOne";
                    break;
                case 2:
                    levelName = "levelTwo";
                    break;
                case 3:
                    levelName = "levelThree";
                    break;
            }

            return levelName;
        }

        /// <summary>
        /// Insert the power into the database
        /// </summary>
        /// <param name="power">power object</param>
        private void InsertPower(Power power, int idCharacter)
        {
            string req = "";

            if (power.IsUltime)
            {
                // Request
                req = $"INSERT INTO t_power (`idPower`, `powName`, `powDescription`, `powCapacity`, `powNbTurns`, `powPercentageUpPerHit`, `powPercentageUpPerKill`, `powIsUltime`, `powNbTargets`, `idCharacter`) " +
                    $"VALUES (NULL, @powName, @powDescription, @powCapacity, @powNbTurns, @powPercentageUpPerHit, @powPercentageUpPerKill, @powIsUltime, @powNbTargets, @idCharacter);";

                //Binds
                _binds = new Dictionary<string, string>();
                _binds.Add("@powName", power.Name);
                _binds.Add("@powDescription", power.Description);
                _binds.Add("@powCapacity", power.Capacity);
                _binds.Add("@powNbTurns", power.NbTurns.ToString());
                _binds.Add("@powPercentageUpPerHit", power.PercentageUpPerHit.ToString());
                _binds.Add("@powPercentageUpPerKill", power.PercentageUpPerKill.ToString());
                _binds.Add("@powIsUltime", power.IsUltime == true ? "1" : "0");
                _binds.Add("@powNbTargets", power.NbTargets.ToString());
                _binds.Add("@idCharacter", idCharacter.ToString());
            }
            else
            {
                // Request
                req = $"INSERT INTO t_power (`idPower`, `powName`, `powDescription`, `powCapacity`, `powLoadTurns`, `powNbTurns`, `powIsUltime`, `powNbTargets`, `idCharacter`) " +
                    $"VALUES (NULL, @powName, @powDescription, @powCapacity, @powLoadTurns, @powNbTurns, @powIsUltime, @powNbTargets, @idCharacter);";

                //Binds
                _binds = new Dictionary<string, string>();
                _binds.Add("@powName", power.Name);
                _binds.Add("@powDescription", power.Description);
                _binds.Add("@powCapacity", power.Capacity);
                _binds.Add("@powLoadTurns", power.LoadTurns.ToString());
                _binds.Add("@powNbTurns", power.NbTurns.ToString());
                _binds.Add("@powIsUltime", power.IsUltime == true ? "1" : "0");
                _binds.Add("@powNbTargets", power.NbTargets.ToString());
                _binds.Add("@idCharacter", idCharacter.ToString());
            }

            // Get the datas by requesting the database
            Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);
        }


        /// <summary>
        /// Create a ultime for a character
        /// </summary>
        /// <param name="characterName">Name of the character</param>
        /// <param name="powerName">Power name</param>
        /// <returns>Return an ultime</returns>
        public Power CreateUltime(string characterName, string powerName, int characterLevel)
        {
            // Get the name of the level
            string levelName = GetLevelName(characterLevel);

            // Get the capacity of a power
            string capacity = JToken.Parse(GetPowerCapacity(powerName, levelName)).ToString();

            // Get the number of turns the power affects his target
            int nbTurns = GetPowerNbTurns(powerName);

            // Get the numbet of targets of the power
            int nbTargets = GetPowerTargets(powerName);

            // Get the number of percentage up per hit
            int percentageUpPerHit = GetPercentageUpPerHit(powerName);

            // Get the number of percentage up per kill
            int percentageUpPerKill = GetPercentageUpPerKill(powerName);

            // Create the ultime
            Power power = new Power(JToken.Parse(powerName).ToString(), "", capacity, percentageUpPerHit, percentageUpPerKill, nbTurns, nbTargets);
            power.IsUltime = true;

            // Get the id of the character
            int idCharacter = _chestsController.GetCharacterId(characterName);

            // Insert the power into the database
            InsertPower(power, idCharacter);

            // Return the power
            return power;
        }

        /// <summary>
        /// Get the power capacity
        /// </summary>
        /// <param name="nickname">power name</param>
        /// <returns>Return the power capacity</returns>
        public string GetPowerCapacity(string powerName, string levelName)
        {
            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.{levelName}' AS 'PowCapacity' FROM t_upgrade WHERE upgCapacity->'$.{powerName}.{levelName}' IS NOT NULL";
        
            //Columns name
            _columns = new List<string>();
            _columns.Add("PowCapacity");

            // Get the datas by requesting the database
            return Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0];
        }

        /// <summary>
        /// Get the number that the power affects his target
        /// </summary>
        /// <param name="powerName">power name</param>
        /// <returns>Return the number of targets affected</returns>
        public int GetPowerNbTurns(string powerName)
        {
            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.nbTurns' AS 'nbTurns' FROM t_upgrade WHERE upgCapacity->'$.{powerName}.nbTurns' IS NOT NULL";

            //Columns name
            _columns = new List<string>();
            _columns.Add("nbTurns");

            // Get the datas by requesting the database
            return Convert.ToInt32(JToken.Parse(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]));
        }

        /// <summary>
        /// Get the percentage up per hit for the ultime
        /// </summary>
        /// <param name="powerName">Power name</param>
        /// <returns>Return the percentage up per hit</returns>
        public int GetPercentageUpPerHit(string powerName)
        {
            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.percentageUpPerHit' AS 'nbTurns' FROM t_upgrade WHERE upgCapacity->'$.{powerName}.percentageUpPerHit' IS NOT NULL";

            //Columns name
            _columns = new List<string>();
            _columns.Add("nbTurns");

            // Get the datas by requesting the database
            return Convert.ToInt32(JToken.Parse(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]));
        }

        /// <summary>
        /// Get the percentage up per kill for the ultime
        /// </summary>
        /// <param name="powerName">Power name</param>
        /// <returns>Return the percentage up per kill</returns>
        public int GetPercentageUpPerKill(string powerName)
        {
            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.percentageUpPerKill' AS 'nbTurns' FROM t_upgrade WHERE upgCapacity->'$.{powerName}.percentageUpPerKill' IS NOT NULL";

            //Columns name
            _columns = new List<string>();
            _columns.Add("nbTurns");

            // Get the datas by requesting the database
            return Convert.ToInt32(JToken.Parse(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]));
        }

        /// <summary>
        /// Get the number of targets that the power affects to
        /// </summary>
        /// <param name="powerName">power name</param>
        /// <returns>Return the power targets</returns>
        public int GetPowerTargets(string powerName)
        {
            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.nbTargets' AS 'nbTargets' FROM t_upgrade WHERE upgCapacity->'$.{powerName}.nbTargets' IS NOT NULL";

            //Columns name
            _columns = new List<string>();
            _columns.Add("nbTargets");

            // Get the datas by requesting the database
            return Convert.ToInt32(JToken.Parse(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]));
        }

        /// <summary>
        /// Get the number of turns to load the power
        /// </summary>
        /// <param name="powerName">Power name</param>
        /// <returns>Return the nb of turns to load the power</returns>
        public int GetPowerNbLoadTurns(string powerName)
        {
            // Request
            string req = $"SELECT upgCapacity->'$.{powerName}.nbLoadTurns' AS 'nbLoadTurns' FROM t_upgrade WHERE upgCapacity->'$.{powerName}.nbLoadTurns' IS NOT NULL";

            //Columns name
            _columns = new List<string>();
            _columns.Add("nbLoadTurns");

            // Get the datas by requesting the database
            return Convert.ToInt32(JToken.Parse(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]));
        }

        /// <summary>
        /// Get the powers name of a character
        /// </summary>
        /// <param name="characterName">Character name</param>
        /// <returns>Return a dictionary of powers name</returns>
        public Dictionary<string, string> GetPowersNameByCharacterName(string characterName)
        {
            //Request
            string req = $"SELECT upgCapacity->'$.names.Power1' AS 'Power1', upgCapacity->'$.names.Power2' AS 'Power2', upgCapacity->'$.names.Power3' AS 'Power3' FROM t_upgrade WHERE upgCharacterName = @characterName";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@characterName", characterName);

            //Columns name
            _columns = new List<string>();
            _columns.Add("Power1");
            _columns.Add("Power2");
            _columns.Add("Power3");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);
            Dictionary<string, string> powersName = new Dictionary<string, string>();
            powersName.Add("Power1", datas[0][0]);
            powersName.Add("Power2", datas[1][0]);
            powersName.Add("Power3", datas[2][0]);

            return powersName;
        }

        /// <summary>
        /// Get the powers of a character
        /// </summary>
        /// <returns></returns>
        public List<Power> GetPowers(int idCharacter)
        {
            // Request
            string req = $"SELECT * FROM t_power WHERE idCharacter = @idCharacter";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@idCharacter", idCharacter.ToString());

            //Columns name
            _columns = new List<string>();
            _columns.Add("idPower");
            _columns.Add("powName");
            _columns.Add("powDescription");
            _columns.Add("powCapacity");
            _columns.Add("powLoadTurns");
            _columns.Add("powNbTurns");
            _columns.Add("powPercentageUpPerHit");
            _columns.Add("powPercentageUpPerKill");
            _columns.Add("powIsUltime");
            _columns.Add("powNbTargets");
            _columns.Add("idCharacter");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // Get the datas
            List<Power> powers = new List<Power>();
            for (int i = 0; i < datas[0].Count(); i++)
            {
                // Set ultime or power
                if (datas[8][i] == "0")
                {
                    Power power = new Power(datas[1][i], datas[2][i], datas[3][i], Convert.ToInt32(datas[4][i]), Convert.ToInt32(datas[5][i]), Convert.ToInt32(datas[9][i]));
                    powers.Add(power);
                }
                else
                {
                    Power ultime = new Power(datas[1][i], datas[2][i], datas[3][i], Convert.ToInt32(datas[6][i]), Convert.ToInt32(datas[7][i]), Convert.ToInt32(datas[5][i]), Convert.ToInt32(datas[9][i]));
                    powers.Add(ultime);
                }
            }

            return powers;
        }
        #endregion
    }
}
