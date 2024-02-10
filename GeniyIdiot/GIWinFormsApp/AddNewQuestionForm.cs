using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GIWinFormsApp
{
	public partial class AddNewQuestionForm : Form
	{
		public AddNewQuestionForm()
		{
			InitializeComponent();
		}

		private void AddNewQuestionForm_Load(object sender, EventArgs e)
		{

		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var parsed = InputValidator.TryParseToNumber(questionAnswerTextBox.Text, out var userAnswer, out string errorMessage);

			if (!parsed)
			{
				MessageBox.Show(errorMessage);
			}

			var newQuestion = new Question(questionTextBox.Text, userAnswer);
			QuestionsStorage.Add(newQuestion);

			Close();
		}

		private void questionTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
