﻿using GeniyIdiot.Common;
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
	public partial class ResultsForm : Form
	{
		public ResultsForm()
		{
			InitializeComponent();
		}

		private void ResultsForm_Load(object sender, EventArgs e)
		{
			var results = UserResultsStorage.GetUserResults();

			foreach (var result in results)
			{
				resultsDataGridView.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnose);
			}

		}

		private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
