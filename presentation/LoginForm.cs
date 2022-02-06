using GEO_Quiz.domain;
using System;
using System.Windows.Forms;

namespace GEO_Quiz.presentation
{
    public partial class LoginForm : Form
    {
        private readonly LoginService loginService;
        private readonly MenuForm menuForm;

        public LoginForm(LoginService loginService, MenuForm menuForm)
        {
            this.loginService = loginService;
            this.menuForm = menuForm;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = this.loginService.Login(usernameInput.Text);
            if (isLoggedIn)
            {
                this.Hide();
                this.menuForm.ShowWithUsername();
            }
        }
    }
}
