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
			menuStrip1 = new MenuStrip();
			файоToolStripMenuItem = new ToolStripMenuItem();
			показатьПредыдущиеРезультатыToolStripMenuItem = new ToolStripMenuItem();
			рестартToolStripMenuItem = new ToolStripMenuItem();
			выходToolStripMenuItem = new ToolStripMenuItem();
			вопросыToolStripMenuItem = new ToolStripMenuItem();
			списокВсехВопросовToolStripMenuItem = new ToolStripMenuItem();
			добавитьНовыйВопросToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// nextButton
			// 
			nextButton.Location = new Point(12, 145);
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
			questionNumberLabel.Location = new Point(12, 36);
			questionNumberLabel.Name = "questionNumberLabel";
			questionNumberLabel.Size = new Size(90, 20);
			questionNumberLabel.TabIndex = 1;
			questionNumberLabel.Text = "Вопрос №1";
			// 
			// questionTextLabel
			// 
			questionTextLabel.AutoSize = true;
			questionTextLabel.Location = new Point(12, 65);
			questionTextLabel.Name = "questionTextLabel";
			questionTextLabel.Size = new Size(108, 20);
			questionTextLabel.TabIndex = 2;
			questionTextLabel.Text = "Текст вопроса";
			// 
			// userAnswerTextBox
			// 
			userAnswerTextBox.Location = new Point(12, 99);
			userAnswerTextBox.Name = "userAnswerTextBox";
			userAnswerTextBox.Size = new Size(222, 27);
			userAnswerTextBox.TabIndex = 3;
			userAnswerTextBox.TextChanged += questionAnswerTextBox_TextChanged;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { файоToolStripMenuItem, вопросыToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(553, 28);
			menuStrip1.TabIndex = 4;
			menuStrip1.Text = "menuStrip1";
			// 
			// файоToolStripMenuItem
			// 
			файоToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { показатьПредыдущиеРезультатыToolStripMenuItem, рестартToolStripMenuItem, выходToolStripMenuItem });
			файоToolStripMenuItem.Name = "файоToolStripMenuItem";
			файоToolStripMenuItem.Size = new Size(59, 24);
			файоToolStripMenuItem.Text = "Файл";
			файоToolStripMenuItem.Click += файоToolStripMenuItem_Click;
			// 
			// показатьПредыдущиеРезультатыToolStripMenuItem
			// 
			показатьПредыдущиеРезультатыToolStripMenuItem.Name = "показатьПредыдущиеРезультатыToolStripMenuItem";
			показатьПредыдущиеРезультатыToolStripMenuItem.Size = new Size(331, 26);
			показатьПредыдущиеРезультатыToolStripMenuItem.Text = "Показать предыдущие результаты";
			показатьПредыдущиеРезультатыToolStripMenuItem.Click += показатьПредыдущиеРезультатыToolStripMenuItem_Click;
			// 
			// рестартToolStripMenuItem
			// 
			рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
			рестартToolStripMenuItem.Size = new Size(331, 26);
			рестартToolStripMenuItem.Text = "Рестарт";
			рестартToolStripMenuItem.Click += рестартToolStripMenuItem_Click;
			// 
			// выходToolStripMenuItem
			// 
			выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			выходToolStripMenuItem.Size = new Size(331, 26);
			выходToolStripMenuItem.Text = "Выход";
			выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
			// 
			// вопросыToolStripMenuItem
			// 
			вопросыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { списокВсехВопросовToolStripMenuItem, добавитьНовыйВопросToolStripMenuItem });
			вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
			вопросыToolStripMenuItem.Size = new Size(86, 24);
			вопросыToolStripMenuItem.Text = "Вопросы";
			// 
			// списокВсехВопросовToolStripMenuItem
			// 
			списокВсехВопросовToolStripMenuItem.Name = "списокВсехВопросовToolStripMenuItem";
			списокВсехВопросовToolStripMenuItem.Size = new Size(264, 26);
			списокВсехВопросовToolStripMenuItem.Text = "Список всех вопросов";
			списокВсехВопросовToolStripMenuItem.Click += списокВсехВопросовToolStripMenuItem_Click;
			// 
			// добавитьНовыйВопросToolStripMenuItem
			// 
			добавитьНовыйВопросToolStripMenuItem.Name = "добавитьНовыйВопросToolStripMenuItem";
			добавитьНовыйВопросToolStripMenuItem.Size = new Size(264, 26);
			добавитьНовыйВопросToolStripMenuItem.Text = "Добавить новый вопрос";
			добавитьНовыйВопросToolStripMenuItem.Click += добавитьНовыйВопросToolStripMenuItem_Click;
			// 
			// mainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 307);
			Controls.Add(userAnswerTextBox);
			Controls.Add(questionTextLabel);
			Controls.Add(questionNumberLabel);
			Controls.Add(nextButton);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "mainForm";
			Text = "GeniyIdiot";
			Load += mainForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button nextButton;
		private Label questionNumberLabel;
		private Label questionTextLabel;
		private TextBox userAnswerTextBox;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem файоToolStripMenuItem;
		private ToolStripMenuItem показатьПредыдущиеРезультатыToolStripMenuItem;
		private ToolStripMenuItem рестартToolStripMenuItem;
		private ToolStripMenuItem выходToolStripMenuItem;
		private ToolStripMenuItem списокВопросовToolStripMenuItem;
		private ToolStripMenuItem вопросыToolStripMenuItem;
		private ToolStripMenuItem добавитьНовыйВопросToolStripMenuItem;
		private ToolStripMenuItem списокВсехВопросовToolStripMenuItem;
	}
}