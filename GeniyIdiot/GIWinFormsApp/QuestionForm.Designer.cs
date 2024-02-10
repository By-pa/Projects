namespace GIWinFormsApp
{
	partial class QuestionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView1 = new DataGridView();
			Вопрос = new DataGridViewTextBoxColumn();
			Действие = new DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Вопрос, Действие });
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(728, 426);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Вопрос
			// 
			Вопрос.HeaderText = "QuestionColumn";
			Вопрос.MinimumWidth = 6;
			Вопрос.Name = "Вопрос";
			Вопрос.Width = 500;
			// 
			// Действие
			// 
			Действие.HeaderText = "ActionColumn";
			Действие.MinimumWidth = 6;
			Действие.Name = "Действие";
			Действие.Resizable = DataGridViewTriState.True;
			Действие.SortMode = DataGridViewColumnSortMode.Automatic;
			Действие.Width = 125;
			// 
			// ListQuestions
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(741, 438);
			Controls.Add(dataGridView1);
			Name = "ListQuestions";
			Text = "ListQuestions";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Вопрос;
		private DataGridViewButtonColumn Действие;
	}
}