using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIWinFormsApp
{
	public partial class QuestionsListForm : Form
	{
		public QuestionsListForm()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void QuestionsListForm_Load(object sender, EventArgs e)
		{
			var questions = QuestionsStorage.GetAll();
			foreach (var question in questions)
			{
				questionsDataGridView.Rows.Add(question.Text, question.Answer);
			}
		}

		private void DeletedButton_Click(object sender, EventArgs e)
		{
			var rows = questionsDataGridView.SelectedRows;
			if(rows.Count == 0)
			{
				MessageBox.Show("Вы не выбрали строку");
				return;
			}
			var questionText = rows[0].Cells[0].Value.ToString();
			if (questionText != null)
			{
				QuestionsStorage.Remove(questionText);
			}
			Close();
		}
	}
}
