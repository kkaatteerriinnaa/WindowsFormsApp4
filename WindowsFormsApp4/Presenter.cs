using System;
using Magic8Ball.Model;

namespace Magic8Ball.Presenter
{
    public class Magic8BallPresenter
    {
        private IView _view;
        private AnswerModel _model;

        public Magic8BallPresenter(IView view)
        {
            _view = view;
            _model = new AnswerModel();
        }

        public void AskQuestion(string question)
        {
            string answer = _model.GetAnswer();
            _view.DisplayAnswer(answer);
        }
    }
}