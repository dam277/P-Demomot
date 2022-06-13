using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.utils
{
    public class Power
    {
        private string _name;
        private string _description;
        private int _damages;
        private int _loadTurns;
        private int _nbTurns;
        private int _percentage;
        private int _percentageUpPerHit;
        private int _percentageUpPerKill;

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public int Damages
        {
            get { return _damages; }
        }

        public int LoadTurns
        {
            get { return _loadTurns; }
        }
        
        public int NbTurns
        {
            get { return _nbTurns; }
        }

        public int Percentage
        {
            get { return _percentage; }
        }

        public int PercentageUpPerHit
        {
            get { return _percentageUpPerHit; }
        }

        public int PercentageUpPerKill
        {
            get { return _percentageUpPerKill; }
        }

        /// <summary>
        /// Basic power class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="damages"></param>
        /// <param name="loadTurns"></param>
        public Power(string name, string description, int damages, int loadTurns, int nbTurns)
        {
            _name = name;
            _description = description;
            _damages = damages;
            _loadTurns = loadTurns;
            _nbTurns = nbTurns;
            Console.ReadLine
        }

        /// <summary>
        /// Ultimate power class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="damages"></param>
        /// <param name="percentage"></param>
        /// <param name="percentageUpPerHit"></param>
        /// <param name="percentageUpPerKill"></param>
        public Power(string name, string description, int damages, int percentageUpPerHit, int percentageUpPerKill, int nbTurns)
        {
            _name = name;
            _description = description;
            _damages = damages;
            _percentage = 0;
            _percentageUpPerHit = percentageUpPerHit;
            _percentageUpPerKill = percentageUpPerKill;
            _nbTurns = nbTurns;
        }
    }
}
