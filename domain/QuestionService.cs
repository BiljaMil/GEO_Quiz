using GEO_Quiz.data;
using System;

namespace GEO_Quiz.domain
{
    public class QuestionService
    {
        public Question GetQuestion()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 10);
            return Questions.questions[randomIndex];
        }
    }
}
