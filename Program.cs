using GEO_Quiz.domain;
using GEO_Quiz.presentation;
using System;
using System.Windows.Forms;

namespace GEO_Quiz
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoginService loginService = new LoginService();
            QuestionService questionService = new QuestionService();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            QuizForm quizForm = new QuizForm(questionService);
            MenuForm menuForm = new MenuForm(loginService, quizForm);
            LoginForm loginForm = new LoginForm(loginService, menuForm);
            Application.Run(loginForm);
        }
    }
}
