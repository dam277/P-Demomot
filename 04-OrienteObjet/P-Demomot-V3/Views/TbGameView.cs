using P_Demomot.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Demomot.Views
{
    public partial class TbGameView : Form
    {
        private MainController _mainController;         // Main controller

        /// <summary>
        /// Public main controller
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        public TbGameView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbGameView_Load(object sender, EventArgs e)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int i = 0; i < 14; i++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(pnlGame.Height / 9 + 1, pnlGame.Height / 9 + 1);
                    panel.BackColor = Color.FromArgb(0, 128, 0);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Location = new Point(panel.Width * i, panel.Height * y);
                    pnlGame.Controls.Add(panel);
                }
            }
        }
    }
}
