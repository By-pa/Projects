namespace GIWinFormsApp
{
	partial class mainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			nextButton = new Button();
			questionNumberLabel = new Label();
			questionTextLabel = new Label();
			userAnswerTextBox = new TextBox();
			SuspendLayout();
			// 
			// nextButton
			// 
			nextButton.Location = new Point(12, 221);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(222, 101);
			nextButton.TabIndex = 0;
			nextButton.Text = "Далее";
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// questionNumberLabel
			// 
			questionNumberLabel.AutoSize = true;
			questionNumberLabel.Location = new Point(12, 9);
			questionNumberLabel.Name = "questionNumberLabel";
			questionNumberLabel.Size = new Size(90, 20);
			questionNumberLabel.TabIndex = 1;
			questionNumberLabel.Text = "Вопрос №1";
			// 
			// questionTextLabel
			// 
			questionTextLabel.AutoSize = true;
			questionTextLabel.Location = new Point(12, 56);
			questionTextLabel.Name = "questionTextLabel";
			questionTextLabel.Size = new Size(108, 20);
			questionTextLabel.TabIndex = 2;
			questionTextLabel.Text = "Текст вопроса";
			// 
			// userAnswerTextBox
			// 
			userAnswerTextBox.Location = new Point(12, 128);
			userAnswerTextBox.Name = "userAnswerTextBox";
			userAnswerTextBox.Size = new Size(125, 27);
			userAnswerTextBox.TabIndex = 3;
			userAnswerTextBox.TextChanged += questionAnswerTextBox_TextChanged;
			// 
			// mainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(752, 390);
			Controls.Add(userAnswerTextBox);
			Controls.Add(questionTextLabel);
			Controls.Add(questionNumberLabel);
			Controls.Add(nextButton);
			Name = "mainForm";
			Text = "GeniyIdiot";
			Load += mainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button nextButton;
		private Label questionNumberLabel;
		private Label questionTextLabel;
		private TextBox userAnswerTextBox;
	}
}