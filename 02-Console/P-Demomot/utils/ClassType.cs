using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.utils
{
    public class ClassType
    {
        private string _name;               //  
        private string _descirption;        //

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
        public string Descirption
        {
            get { return _descirption; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public ClassType(string name, string description)
        {
            _name = name;
            _descirption = description;
        }
    }
}
