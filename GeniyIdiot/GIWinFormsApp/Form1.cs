using GeniyIdiot.Common;
using Microsoft.VisualBasic.ApplicationServices;
using User = GeniyIdiot.Common.User;

namespace GIWinFormsApp
{
	public partial class mainForm : Form
	{
		private List<Question> questions;
		private Question currentQuestion;
		private User user;
		private int countQuestions;
		private int questionNumber = 0;
		public mainForm()
		{
			InitializeComponent();
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			questions = QuestionsStorage.GetAll();
			countQuestions = questions.Count;
			user = new User("Неизвесно");

			ShowNextQuestion();



		}

		private void ShowNextQuestion()
		{
			var random = new Random();
			var randomIndex = random.Next(0, questions.Count);

			currentQuestion = questions[randomIndex];

			questionTextLabel.Text = currentQuestion.Text;
			questionNumber++;
			questionNumberLabel.Text = "Вопрос №" + questionNumber;
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);

			var rightAnswer = currentQuestion.Answer;

			if (userAnswer == rightAnswer)
			{
				user.AcceptRightAnswer();
			}
			questions.Remove(currentQuestion);

			var endGame = questions.Count == 0;
			if (endGame)
			{
				user.Diagnose = CalculateDiagnose.DiagnoseCalculate(countQuestions, user.CountRightAnswers);
				MessageBox.Show(user.Name + ", твой диагноз: " + user.Diagnose);

				return;
			}

			ShowNextQuestion();
		}

		private void questionAnswerTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}