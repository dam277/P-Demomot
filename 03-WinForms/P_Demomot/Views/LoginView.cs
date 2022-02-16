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
    public partial class LoginView : Form
    {
        private MainController _mainController;     //

        /// <summary>
        /// 
        /// </summary>
        public MainController MainController
        {
            get { return _mainController; }
            set { _mainController = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public LoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginView_Load(object sender, EventArgs e)
        {
            _mainController.ChangeLanguage(cmbLang.SelectedIndex);
        }

        private void btnValidateConnection_Click(object sender, EventArgs e)
        {

        }

        private void btnValidateRegister_Click(object sender, EventArgs e)
        {

        }

        private void cmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mainController.ChangeLanguage(cmbLang.SelectedIndex);
        }

        public void UpdateLanguage()
        {
            string title = _mainController.ResourceManager.GetString(lblLoginTitle.Name);
            lblLoginTitle.Text = title;

            foreach (Control control in this.Controls)
            {
                string translation = _mainController.ResourceManager.GetString(control.Name);
                if (translation != null)
                {
                    control.Text = translation;
                }
            }
        }

    }
}
