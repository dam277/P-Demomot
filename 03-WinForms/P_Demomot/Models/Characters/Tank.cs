using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot.Models.Characters
{
    public class Tank : Character
    {
        private int _moves;


        public Tank(int id, int hp, int level, string name, string description, string modelPath, int moves) : base(id, hp, level, name, description, modelPath)
        {
            _moves = moves;
        }


    }
}
