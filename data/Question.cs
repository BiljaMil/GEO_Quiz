namespace GEO_Quiz.data
{
    public class Question
    {
        private string sentence;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;

        public Question(string sentence, string answer1, string answer2, string answer3, string answer4)
        {
            this.sentence = sentence;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.answer4 = answer4;
        }

        public string GetSentence() { return sentence; }
        public string GetAnswer1() { return answer1; }
        public string GetAnswer2() { return answer2; }
        public string GetAnswer3() { return answer3; }
        public string GetAnswer4() { return answer4; }
    }


}
