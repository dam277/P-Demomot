using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.UserInfos
{
    class Rank
    {
        #region Variables
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
        #endregion

        #region Constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="points">rank points</param>
        /// <param name="name">rank name</param>
        private Rank(int points, string name)
        {
            _points = points;
            _name = name;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Get a rank with his points
        /// </summary>
        /// <param name="points">rank points</param>
        /// <returns></returns>
        public Rank GetRankByPoints(int points)
        {
            return null;
        }
        #endregion
    }
}
