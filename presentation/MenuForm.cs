using GEO_Quiz.domain;
using GEO_Quiz.presentation;
using System;
using System.Windows.Forms;

namespace GEO_Quiz
{
    public partial class MenuForm : Form
    {
        private readonly LoginService loginService;
        private readonly QuizForm quizForm;
        public MenuForm(LoginService loginService, QuizForm quizForm)
        {
            InitializeComponent();
            this.loginService = loginService;
            this.quizForm = quizForm;
        }

        public void ShowWithUsername()
        {
            this.Show();
            welcomeLabel.Text = "Willkommen " + this.loginService.GetLoggedInUser().GetUsername();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.quizForm.ShowWithQuestion();
        }
    }
}
