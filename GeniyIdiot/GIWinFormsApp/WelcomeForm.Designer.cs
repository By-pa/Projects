namespace GIWinFormsApp
{
	partial class WelcomeForm
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
			label1 = new Label();
			label2 = new Label();
			userNameTextBox = new TextBox();
			startButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(170, 26);
			label1.Name = "label1";
			label1.Size = new Size(194, 20);
			label1.TabIndex = 0;
			label1.Text = "Добро пожаловать в игру!";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(170, 103);
			label2.Name = "label2";
			label2.Size = new Size(133, 20);
			label2.TabIndex = 1;
			label2.Text = "Введите свое имя";
			label2.Click += label2_Click;
			// 
			// userNameTextBox
			// 
			userNameTextBox.Location = new Point(170, 151);
			userNameTextBox.Name = "userNameTextBox";
			userNameTextBox.Size = new Size(210, 27);
			userNameTextBox.TabIndex = 2;
			// 
			// startButton
			// 
			startButton.Location = new Point(170, 201);
			startButton.Name = "startButton";
			startButton.Size = new Size(210, 71);
			startButton.TabIndex = 3;
			startButton.Text = "Начать";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += startButton_Click;
			// 
			// WelcomeForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 307);
			Controls.Add(startButton);
			Controls.Add(userNameTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "WelcomeForm";
			Text = "WelcomeForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		public TextBox userNameTextBox;
		private Button startButton;
	}
}