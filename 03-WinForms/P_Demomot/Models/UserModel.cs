using P_Demomot.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models
{
    public class UserModel
    {
        /// <summary>
        /// INT
        /// </summary>
        private int _id;
        private int _gold = 0;

        /// <summary>
        /// STRING
        /// </summary>
        private string _name;
        private string _email;
        private string _password;
        
        /// <summary>
        /// OBJECTS
        /// </summary>
        private List<Character> _fighters;
        private List<Tank> _tanks;

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public UserModel(string name, string email, string password)
        {
            _name = name;
            _email = email;
            _password = password;
            _fighters = new List<Character>();
            _tanks = new List<Tank>();
        }

        public void FillCharacterLists()
        {
            //Fighters
            

            //Tanks
        }


    }
}
