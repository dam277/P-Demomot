using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Characters.Specifications
{
    public class Types
    {
        /// <summary>
        /// STRING
        /// </summary>
        private string _name;               //
        private string _description;        //

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
        /// <param name="name"></param>
        /// <param name="description"></param>
        public Types(string name, string description)
        {
            _name = name;
            _description = description;
        }
    }
}
