using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Databases;
using P_Demomot.Models.Utils;

namespace P_Demomot.Models.Characters
{
    public class Fighter : Character
    {
        #region Variables
        private InventoryController _inventoryController;   // Inventory controller
        private Dictionary<string, Power> _powers;          // Powers of a fighter
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public Dictionary of powers
        /// </summary>
        public Dictionary<string, Power> Power
        {
            get
            {
                return _powers;
            }
            set
            {
                _powers = value;
            }
        }

        /// <summary>
        /// Public list of fighters
        /// </summary>
        public List<Fighter> FightersList
        {
            get
            {
                return _fightersList;
            }
            set
            {
                _fightersList = value;
            }
        }

        /// <summary>
        /// Public list of fighters
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
        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Fighter()
        {
            _fightersList = new List<Fighter>();
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id">Id of the character</param>
        /// <param name="model">Model of the character</param>
        /// <param name="name">name of the character</param>
        /// <param name="level">level of the character</param>
        /// <param name="rarity">rarity of the character</param>
        /// <param name="life">life of the character</param>
        public Fighter(int id, string model, string name, int level, Rarity rarity, int life) : base(id, model, name, level, rarity, life)
        {
            _powers = new Dictionary<string, Power>();
        }

        /// <summary>
        /// Models of fighters class constructor
        /// </summary>
        /// <param name="name">Name of the figter</param>
        /// <param name="rarity">Rarity of the fighter</param>
        public Fighter(string name, Rarity rarity) : base(name, rarity)
        {
            _powers = new Dictionary<string, Power>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Create the first character when sign up
        /// </summary>
        /// <param name="character">Model (object) of the character</param>
        /// <param name="chaModel">Graphic model of the character</param>
        /// <param name="chaGame">Game who the character is</param>
        /// <param name="idUser">User id</param>
        /// <param name="rarity">Rarity</param>
        /// <param name="chaLevel">Level of the character</param>
        /// <returns>Return the first character</returns>
        public Character CreateFirstCharacter(Character character, string chaModel, int chaGame, int idUser, Rarity rarity , int chaLevel = 1)
        {
            // Get the life of the character
            string life = JToken.Parse(GetLifeOfCharacter(character.Name, chaLevel)).ToString();

            // Get the upgrade id of the character
            string idUpgrade = GetUpgradeId(character.Name);

            // Insert a new character
            // Request
            string req = $"INSERT INTO t_character (`idCharacter`, `chaName`, `chaModel`, `chaLevel`, `chaLife`, `chaGame`, `idUser`, `idRarity`, `idUpgrade`)" +
                $" VALUES (NULL, @name, @model, @level, @life ,@game ,@idUser ,@idRarity ,@idUpgrade)";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@name", character.Name);
            _binds.Add("@model", chaModel);
            _binds.Add("@level", chaLevel.ToString());
            _binds.Add("@life", life);
            _binds.Add("@game", chaGame.ToString());
            _binds.Add("@idUser", idUser.ToString());
            _binds.Add("@idRarity", rarity.Id.ToString());
            _binds.Add("@idUpgrade", idUpgrade);

            //Columns name
            _columns = new List<string>();
            _columns.Add("idCharacter");
            _columns.Add("chaName");
            _columns.Add("chaModel");
            _columns.Add("chaLevel");
            _columns.Add("chaLife");
            _columns.Add("chaGame");
            _columns.Add("idUser");
            _columns.Add("idRarity");
            _columns.Add("idUpgrade");

            // Execute query
            Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // Return the fighter
            return new Fighter(GetId(character.Name, idUser), chaModel, character.Name, chaLevel, rarity, Convert.ToInt32(life));
        }

        /// <summary>
        /// Get the id of the character
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetId(string name, int idUser)
        {
            // Request
            string req = $"SELECT idCharacter FROM t_character WHERE chaName = @name AND idUser = @idUser";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@name", name);
            _binds.Add("@idUser", idUser.ToString());

            //Columns name
            _columns = new List<string>();
            _columns.Add("idCharacter");

            // Get the datas by requesting the database
            return Convert.ToInt32(Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns)[0][0]);
        }

        /// <summary>
        /// Get the upgrade id of the character
        /// </summary>
        /// <param name="characterName">character name</param>
        /// <returns>Return the id of the his upgrades</returns>
        public string GetUpgradeId(string characterName)
        {
            //Request
            string req = $"SELECT idUpgrade FROM `t_upgrade` WHERE upgCharacterName = @characterName";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@characterName", characterName);

            //Columns name
            _columns = new List<string>();
            _columns.Add("idUpgrade");

            // Get the datas by requesting the database

            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // return the content
            return datas[0][0];
        }

        /// <summary>
        /// Get the life of a character
        /// </summary>
        /// <param name="characterName">character name</param>
        /// <param name="level">character level</param>
        /// <returns>Return the life of a character</returns>
        public string GetLifeOfCharacter(string characterName, int level)
        {
            // Get the level name
            string levelName = "";
            switch(level)
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
                default:
                    levelName = "levelZero";
                    break;
            }

            //Request
            string req = $"SELECT upgLife->'$.{levelName}' AS 'upgLife' FROM `t_upgrade` WHERE upgCharacterName = @characterName";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@characterName", characterName);

            //Columns name
            _columns = new List<string>();
            _columns.Add("upgLife");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // return the content
            return datas[0][0];
        }

        /// <summary>
        /// Create a character intot the database
        /// </summary>
        public void CreateCharacter()
        {
            //Insert a new character
            // Request
            string req = $"INSERT INTO t_character (`idCharacter`, `chaName`, `chaModel`, `chaLevel`, `chaLife`, `chaGame`, `idUser`, `idRarity`, `idUpgrade`)" +
                $" VALUES (NULL, '', '', , , , , , )";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@nickname", "");

            //Columns name
            _columns = new List<string>();
            _columns.Add("idUser");
            _columns.Add("useNickname");
            _columns.Add("usePasswordHash");
            _columns.Add("useEntryDate");
            _columns.Add("usePermLevel");
            _columns.Add("idRank");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Fighter> GetUserFighters(int idUser)
        {
            // Request
            string req = $"SELECT * FROM t_character WHERE idUser = @idUser";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@idUser", idUser.ToString());

            //Columns name
            _columns = new List<string>();
            _columns.Add("idCharacter");
            _columns.Add("chaName");
            _columns.Add("chaModel");
            _columns.Add("chaLevel");
            _columns.Add("chaLife");
            _columns.Add("chaGame");
            _columns.Add("idUser");
            _columns.Add("idRarity");
            _columns.Add("idUpgrade");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            //Create the characters
            List<Fighter> fighters = new List<Fighter>();
            for (int i = 0; i < datas[0].Count(); i++)
            {
                Fighter character = new Fighter(Convert.ToInt32(datas[0][i]), datas[2][i], datas[1][i], Convert.ToInt32(datas[3][i]), new Rarity(), Convert.ToInt32(datas[4][i]));
                //Get his powers
                List<Power> powers = _loginSignInController.GetPowers(character.IdCharacter);
                foreach(Power power in powers)
                {
                    character.AddPower(power);
                }

                fighters.Add(character);
            }

            return fighters;
        }

        /// <summary>
        /// Add a power to the list
        /// </summary>
        /// <param name="power">Power to add</param>
        public void AddPower(Power power)
        {
            _powers.Add(power.Name, power);
        }

        /// <summary>
        /// Add a fighter to the list
        /// </summary>
        /// <param name="fighter">Fighter ro add</param>
        public void AddFighter(Fighter fighter)
        {
            _fightersList.Add(fighter);
        }
        #endregion
    }
}
