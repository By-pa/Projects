namespace GIWinFormsApp
{
	partial class AddNewQuestionForm
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
			questionAnswerTextBox = new TextBox();
			label1 = new Label();
			label2 = new Label();
			questionTextBox = new TextBox();
			AddButton = new Button();
			SuspendLayout();
			// 
			// questionAnswerTextBox
			// 
			questionAnswerTextBox.Location = new Point(190, 77);
			questionAnswerTextBox.Name = "questionAnswerTextBox";
			questionAnswerTextBox.Size = new Size(351, 27);
			questionAnswerTextBox.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 27);
			label1.Name = "label1";
			label1.Size = new Size(108, 20);
			label1.TabIndex = 0;
			label1.Text = "Текст вопроса";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(39, 80);
			label2.Name = "label2";
			label2.Size = new Size(111, 20);
			label2.TabIndex = 1;
			label2.Text = "Ответ вопроса";
			// 
			// questionTextBox
			// 
			questionTextBox.Location = new Point(190, 27);
			questionTextBox.Name = "questionTextBox";
			questionTextBox.Size = new Size(351, 27);
			questionTextBox.TabIndex = 2;
			questionTextBox.TextChanged += questionTextBox_TextChanged;
			// 
			// AddButton
			// 
			AddButton.Location = new Point(190, 147);
			AddButton.Name = "AddButton";
			AddButton.Size = new Size(209, 81);
			AddButton.TabIndex = 4;
			AddButton.Text = "Добавить";
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += AddButton_Click;
			// 
			// AddNewQuestionForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 307);
			Controls.Add(AddButton);
			Controls.Add(questionAnswerTextBox);
			Controls.Add(questionTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddNewQuestionForm";
			Text = "AddNewQuestionForm";
			Load += AddNewQuestionForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox questionTextBox;
		private TextBox questionAnswerTextBox;
		private Button AddButton;
	}
}