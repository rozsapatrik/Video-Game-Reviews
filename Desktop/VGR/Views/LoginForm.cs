using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VGR.Presenters;
using VGR.ViewInterfaces;

namespace VGR.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        public string UserName
        {
            get => textBoxUsername.Text;
        }

        public string Password
        {
            get => textBoxPassword.Text;
        }

        public string ErrorUserName
        {
            set => errorProviderUsername.SetError(textBoxUsername, value);
        }
        public string ErrorPassword
        {
            set => errorProviderPassword.SetError(textBoxPassword, value);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(presenter.Belepes())
            {
                GamesListForm gamesListForm = new GamesListForm();
                this.Hide();
                gamesListForm.ShowDialog();
                this.Close();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (presenter.Belepes())
            {
                GamesListForm gamesListForm = new GamesListForm();
                this.Hide();
                gamesListForm.ShowDialog();
                this.Close();
            }
        }
    }
}
