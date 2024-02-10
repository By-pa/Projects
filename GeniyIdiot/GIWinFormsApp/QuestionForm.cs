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
	public partial class QuestionForm : Form
	{
		public QuestionForm()
		{
			InitializeComponent();
		}
		private void QuestionsForm_Load(object sender, EventArgs e)
		{
			var results = QuestionsStorage.GetAll();

			for (int i = 0; i < results.Count; i++)
			{
				dataGridView1.Rows.Add(results[i]);
			}

		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
