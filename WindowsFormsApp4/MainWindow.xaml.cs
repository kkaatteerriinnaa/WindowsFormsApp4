using System.Windows;
using Magic8Ball.Presenter;

namespace Magic8Ball
{
    public partial class MainWindow : Window, IView
    {
        private Magic8BallPresenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            _presenter = new Magic8BallPresenter(this);
            AskButton.Click += (sender, args) => _presenter.AskQuestion(QuestionBox.Text);
        }

        public void DisplayAnswer(string answer)
        {
            AnswerBox.Text = answer;
        }
    }
}