using GEO_Quiz.data;
using GEO_Quiz.domain;
using System;
using System.Windows.Forms;

namespace GEO_Quiz.presentation
{
    public partial class QuizForm : Form
    {
        private readonly QuestionService questionService;

        public QuizForm(QuestionService questionService)
        {
            InitializeComponent();
            this.questionService = questionService;
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        public void ShowWithQuestion()
        {
            this.Show();
            Question randomQuestion = this.questionService.GetQuestion();
            questionLabel.Text = randomQuestion.GetSentence();
            radioButton1.Text = randomQuestion.GetAnswer1();
            radioButton2.Text = randomQuestion.GetAnswer2();
            radioButton3.Text = randomQuestion.GetAnswer3();
            radioButton4.Text = randomQuestion.GetAnswer4();
        }
    }
}
