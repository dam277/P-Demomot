using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace P_Demomot
{
    class Options
    {
        private SoundPlayer _soundPlayer = new SoundPlayer();

        public Options()
        {

        }

        public void ChangeSound()
        {
            _soundPlayer.Play();
        }
    }
}
