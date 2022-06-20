using P_Demomot.Controllers;
using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Databases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Utils
{
    public class Rarity
    {
        private LoginSignInController _loginSignInController;   // Login signin controller
        private MainController _mainController;

        private Dictionary<int, Tuple<int, int>> _upgrades;
        private int _id;
        private string _name;
        private Color _color;
        private int _dropChance;
        private Dictionary<string, string> _binds;              // Dictionary of binds to the requests
        private List<string> _columns;                          // Columns searched in the request

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

        public LoginSignInController LoginSignInController
        {
            get
            {
                return _loginSignInController;
            }
            set
            {
                _loginSignInController = value;
            }
        }

        public Dictionary<int, Tuple<int, int>> Upgrades
        {
            get
            {
                return _upgrades;
            }
            set
            {
                _upgrades = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Color color
        {
            get
            {
                return _color;
            }
        }

        public int DropChance
        {
            get
            {
                return _dropChance;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Rarity()
        {

        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lvl1UpCards"></param>
        /// <param name="lvl1UpPrice"></param>
        /// <param name="lvl2UpCards"></param>
        /// <param name="lvl2UpPrice"></param>
        public Rarity(int id, string name, int lvl1UpCards, int lvl1UpPrice, int lvl2UpCards, int lvl2UpPrice, Color color, int dropChance)
        {
            _id = id;
            _name = name;
            _upgrades = new Dictionary<int, Tuple<int, int>>();
            _upgrades.Add(1, new Tuple<int, int>(lvl1UpCards, lvl1UpPrice));
            _upgrades.Add(2, new Tuple<int, int>(lvl2UpCards, lvl2UpPrice));
            _color = color;
            _dropChance = dropChance;
        }

        /// <summary>
        /// Get all the rarity of the DB
        /// </summary>
        /// <returns>Returns all the rarity</returns>
        public List<Rarity> GetAllRarity()
        {
            List<Rarity> rarities = new List<Rarity>();

            // Request
            string req = $"SELECT * FROM t_rarity";

            //Columns name
            _columns = new List<string>();
            _columns.Add("idRarity");
            _columns.Add("rarName");
            _columns.Add("rarUpgradePriceLvlOne");
            _columns.Add("rarUpgradePriceLvlTwo");
            _columns.Add("rarUpgradeCardsLvlOne");
            _columns.Add("rarUpgradeCardsLvlTwo");
            _columns.Add("rarColor");
            _columns.Add("rarDropChance");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QuerySimpleExecute(req, _columns);

            Color color = Color.White;
            // Create the rarities from the database
            for (int i = 0; i < datas[0].Count(); i++)
            {
                // Select the color
                switch (datas[6][i])
                {
                    case "Magenta":
                        color = Color.Magenta;
                        break;
                    case "Gray":
                        color = Color.Gray;
                        break;
                    case "Brown":
                        color = Color.Brown;
                        break;
                    case "Green":
                        color = Color.Green;
                        break;
                    case "Yellow":
                        color = Color.Yellow;
                        break;
                    case "Blue":
                        color = Color.Blue;
                        break;
                    case "Purple":
                        color = Color.Purple;
                        break;
                    case "Red":
                        color = Color.Red;
                        break;
                }

                // Create a new rarity
                Rarity rarity = new Rarity(Convert.ToInt32(datas[0][i]), datas[1][i], Convert.ToInt32(datas[2][i]), Convert.ToInt32(datas[3][i]), Convert.ToInt32(datas[4][i]), Convert.ToInt32(datas[5][i]), color, Convert.ToInt32(datas[7][i]));
                rarities.Add(rarity);
            }

            return rarities;
        }

        public Rarity GetRarityByName(string name)
        {
            return null;
        }
    }
}
