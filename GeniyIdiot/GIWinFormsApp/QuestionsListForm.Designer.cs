﻿namespace GIWinFormsApp
{
	partial class QuestionsListForm
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
			questionsDataGridView = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			DeletedButton = new Button();
			((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
			SuspendLayout();
			// 
			// questionsDataGridView
			// 
			questionsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
			questionsDataGridView.Location = new Point(12, 25);
			questionsDataGridView.MultiSelect = false;
			questionsDataGridView.Name = "questionsDataGridView";
			questionsDataGridView.RowHeadersWidth = 51;
			questionsDataGridView.RowTemplate.Height = 29;
			questionsDataGridView.Size = new Size(573, 314);
			questionsDataGridView.TabIndex = 0;
			questionsDataGridView.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Column1
			// 
			Column1.HeaderText = "Текст";
			Column1.MinimumWidth = 6;
			Column1.Name = "Column1";
			Column1.Width = 300;
			// 
			// Column2
			// 
			Column2.HeaderText = "Ответ";
			Column2.MinimumWidth = 6;
			Column2.Name = "Column2";
			Column2.Width = 125;
			// 
			// DeletedButton
			// 
			DeletedButton.Location = new Point(491, 310);
			DeletedButton.Name = "DeletedButton";
			DeletedButton.Size = new Size(94, 29);
			DeletedButton.TabIndex = 1;
			DeletedButton.Text = "Удалить";
			DeletedButton.UseVisualStyleBackColor = true;
			DeletedButton.Click += DeletedButton_Click;
			// 
			// QuestionsListForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(597, 351);
			Controls.Add(DeletedButton);
			Controls.Add(questionsDataGridView);
			Name = "QuestionsListForm";
			Text = "QuestionsListForm";
			Load += QuestionsListForm_Load;
			((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView questionsDataGridView;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private Button DeletedButton;
	}
}