﻿using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Здравствуйте! Как Тебя зовут?)");
				var user = new User(Console.ReadLine());
				var game = new Game(user);


				while (!game.End())
				{
					var currentQuestion = game.GetNextQuestion();
					Console.WriteLine(game.GetQuestionNumberText);
					Console.WriteLine(currentQuestion.Text);

					var userAnswer = GetNumber();

					game.AcceptAnswer(userAnswer);
				}

				var message = game.CalculateDiagnose();
				Console.WriteLine(message);

				var userChoise = GetUserChoise("Хотите посмотреть предыдущие результаты игры");
				if (userChoise)
				{
					ShowUserResults();
				}

				userChoise = GetUserChoise("Хотите начать сначала?");
				if (userChoise == false)
				{
					break;
				}

				userChoise = GetUserChoise("Хотите добавить новый вопрос?");
				if (userChoise)
				{
					AddNewQuestion();
				}

				userChoise = GetUserChoise("Хотите удалить существующий вопрос?");
				if (userChoise)
				{
					RemoveQuestion();
				}

				

			}
		}

		static void RemoveQuestion()
		{
			Console.WriteLine("Введите номер удаляемого вопроса");
			var questions = QuestionsStorage.GetAll();

			for (int i = 0; i < questions.Count; i++)
			{
				Console.WriteLine((i + 1) + ". " + questions[i].Text);
			}

			var removeQuestionNumber = GetNumber();

			while (removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
			{
				Console.WriteLine("Введите число от 1 до " + questions.Count);
				removeQuestionNumber = GetNumber();
			}

			var removeQuestion = questions[removeQuestionNumber - 1];
			QuestionsStorage.Remove(removeQuestion.Text);
		}

		static void AddNewQuestion()
		{
			Console.WriteLine("Введите текст вопроса");
			var text = Console.ReadLine();
			Console.WriteLine("Введите ответ на вопрос");

			var answer = GetNumber();

			var newQuestion = new Question(text, answer);

			QuestionsStorage.Add(newQuestion);
		}

		private static void ShowUserResults()
		{
			var result = UserResultsStorage.GetUserResults();

			Console.WriteLine("{0,-20} {1,18} {2,15}", "Имя", "Кол-во правильных ответов", "Диагноз");

			foreach (var user in result)
			{
				Console.WriteLine("{0,-20}{1,10}{2,35}", user.Name, user.CountRightAnswers, user.Diagnose);
			}
		}

		static int GetNumber()
		{
			int number;
			while (!InputValidator.TryParseToNumber(Console.ReadLine(), out number, out string errorMessage))
			{
				Console.WriteLine(errorMessage);
			}
			return number;
		}

		static bool GetUserChoise(string message)
		{
			while (true)
			{


				Console.WriteLine(message + " Введите Да или Нет");
				var userInput = Console.ReadLine();

				if (userInput.ToLower() == "нет")
				{
					return false;
				}
				if (userInput.ToLower() == "да")
				{
					return true;
				}
			}
		}
	}

}