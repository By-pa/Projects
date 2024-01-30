using GeniyIdiot.Common;

namespace GeniyIdiotConsoleApp
{
	class Program : CalculateDiagnose
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Здравствуйте! Как Тебя зовут?)");
				var userName = Console.ReadLine();

				var user = new User(userName);

				var questions = QuestionsStorage.GetAll();
				var countQuestions = questions.Count;


				Random random = new Random();


				for (int i = 0; i < countQuestions; i++)
				{
					Console.WriteLine($"Вопрос номер: {i + 1}");
					var randomQuestionIndex = random.Next(0, questions.Count);
					Console.WriteLine(questions[randomQuestionIndex].Text);

					var userAnswer = GetNumber();
					var rightAnswer = questions[randomQuestionIndex].Answer;

					if (userAnswer == rightAnswer)
					{
						user.AcceptRightAnswer();
					}
					questions.RemoveAt(randomQuestionIndex);
				}

				Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);

				var diagnose = CalculateDiagnose.DiagnoseCalculate(countQuestions, user.CountRightAnswers);
				user.Diagnose = diagnose;
				Console.WriteLine(userName + ", Ваш диагноз: " + diagnose);

				UserResultsStorage.Save(user);

				var userChoise = GetUserChoise("Хотите посмотреть предыдущие результаты игры");
				if (userChoise)
				{
					ShowUserResults();
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

				userChoise = GetUserChoise("Хотите начать сначала?");
				if (userChoise == false)
				{
					break;
				}

			}
		}

		static void RemoveQuestion()
		{
            Console.WriteLine("Введите номер удаляемого вопроса");
            var questions = QuestionsStorage.GetAll();

			for (int i = 0; i < questions.Count; i++)
			{
                Console.WriteLine((i+1) + ". " + questions[i].Text);
            }

			var removeQuestionNumber = GetNumber();

			while(removeQuestionNumber < 1 || removeQuestionNumber > questions.Count)
			{
                Console.WriteLine("Введите число от 1 до " + questions.Count);
				removeQuestionNumber = GetNumber();
			}

			var removeQuestion = questions[removeQuestionNumber - 1];
			QuestionsStorage.Remove(removeQuestion);
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
			while (true)
			{
				try
				{
					return Convert.ToInt32(Console.ReadLine());
				}
				catch (FormatException)
				{
					Console.WriteLine("Введите число!");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Вы ввели слишком большое число!");
				}



			}
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