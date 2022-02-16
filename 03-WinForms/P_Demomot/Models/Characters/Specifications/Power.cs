using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Characters.Specifications
{
    public class Power
    {
        private string _name;               //
        private string _description;        //
        private int _damage;                //
        private int _load;                  //

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get { return _description; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Damage
        {
            get { return _damage; }
        }    

        /// <summary>
        /// 
        /// </summary>
        public int Load
        {
            get { return _load; }
        }
    }
}
