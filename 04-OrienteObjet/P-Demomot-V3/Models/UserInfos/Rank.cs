using P_Demomot.Controllers.UserProperties;
using P_Demomot.Models.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.UserInfos
{
    public class Rank
    {
        private LoginSignInController _loginSignInController;       // Login signin controller

        #region Variables
        private Dictionary<string, string> _binds;              // Dictionary of binds to the requests
        private List<string> _columns;                          // Columns searched in the request
        private int _id;            // Rank id
        private int _points;        // Rank points
        private string _name;       // Rank name
        #endregion

        #region Getter Setter
        /// <summary>
        /// Public rank points
        /// </summary>
        public int Points
        {
            get 
            { 
                return _points; 
            }
            set 
            { 
                _points = value; 
            }
        }

        /// <summary>
        /// Public rank name
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            { 
                _name = value; 
            }
        }

        /// <summary>
        /// Public rank id
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Public login signin controller
        /// </summary>
        public LoginSignInController LoginSignInController
        {
            get { return _loginSignInController; }
            set { _loginSignInController = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Basic class constructor
        /// </summary>
        public Rank()
        {

        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="points">rank points</param>
        /// <param name="name">rank name</param>
        private Rank(int points, string name, int id)
        {
            _points = points;
            _name = name;
            _id = id;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get a rank with his points
        /// </summary>
        /// <param name="points">rank points</param>
        /// <returns>Return a rank</returns>
        public Rank GetRankByPoints(int points)
        {
            // Request
            string req = $"SELECT * FROM t_rank WHERE ranPoints = @points";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@points", points.ToString());

            //Columns name
            _columns = new List<string>();
            _columns.Add("idRank");
            _columns.Add("ranName");
            _columns.Add("ranPoints");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // Return the rank
            return new Rank(Convert.ToInt32(datas[2][0]), datas[1][0], Convert.ToInt32(datas[0][0]));
        }

        /// <summary>
        /// Get the rank by the rankId
        /// </summary>
        /// <param name="idRank">RankId</param>
        /// <returns>Return a rank</returns>
        public Rank GetRankByID(int idRank)
        {
            // Request
            string req = $"SELECT * FROM t_rank WHERE idRank = @idRank";

            //Binds
            _binds = new Dictionary<string, string>();
            _binds.Add("@idRank", idRank.ToString());

            //Columns name
            _columns = new List<string>();
            _columns.Add("idRank");
            _columns.Add("ranName");
            _columns.Add("ranPoints");

            // Get the datas by requesting the database
            List<string>[] datas = Database.GetInstance().QueryPrepareExecutes(req, _binds, _columns);

            // Return the rank
            return new Rank(Convert.ToInt32(datas[2][0]), datas[1][0], Convert.ToInt32(datas[0][0]));
        }
        #endregion
    }
}
