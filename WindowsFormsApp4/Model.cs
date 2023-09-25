using System;

namespace Magic8Ball.Model
{
    public class AnswerModel
    {
        private Random _random;
        private string[] _answers;

        public AnswerModel()
        {
            _random = new Random();
            _answers = new string[] { "Yes", "No", "Maybe", "Ask again later" };
        }

        public string GetAnswer()
        {
            int index = _random.Next(_answers.Length);
            return _answers[index];
        }
    }
}