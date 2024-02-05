using GeniyIdiot.Common;
using Microsoft.VisualBasic.ApplicationServices;
using User = GeniyIdiot.Common.User;

namespace GIWinFormsApp
{
	public partial class mainForm : Form
	{
		Game game;
		public mainForm()
		{
			InitializeComponent();
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			var welcomeForm = new WelcomeForm();
			welcomeForm.ShowDialog();

			var user = new User(welcomeForm.userNameTextBox.Text);
			game = new Game(user);

			ShowNextQuestion();
		}

		private void ShowNextQuestion()
		{
			var currentQuestion  = game.GetNextQuestion();
			questionTextLabel.Text = currentQuestion.Text;
			questionNumberLabel.Text = game.GetQuestionNumberText();
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out var userAnswer, out string errorMessage);

			if (!parsed)
			{
				MessageBox.Show(errorMessage);
			}

			else
			{
				game.AcceptAnswer(userAnswer);
				if (game.End())
				{
					var message = game.CalculateDiagnose();
					MessageBox.Show(message);
				}
				else
				{
					ShowNextQuestion();
				}
			}
		}

		private void questionAnswerTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void ôàéîToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ğåñòàğòToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}

		private void ïîêàçàòüÏğåäûäóùèåĞåçóëüòàòûToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var resultsForm = new ResultsForm();
			resultsForm.ShowDialog();	
		}
	}
}