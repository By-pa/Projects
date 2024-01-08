using System.Text;

namespace GeniyIdiotConsoleApp
{
	class Program
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

					var userAnswer = GetUserAnswer();
					var rightAnswer = questions[randomQuestionIndex].Answer;

					if (userAnswer == rightAnswer)
					{
						user.AcceptRightAnswer();
					}
					questions.RemoveAt(randomQuestionIndex);
				}

				Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);

				var diagnose = CalculateDiagnose(countQuestions, user.CountRightAnswers);
				user.Diagnose = diagnose;
				Console.WriteLine(userName + ", Ваш диагноз: " + diagnose);

				UserResultsStorage.Save(user);

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

			}
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



		static string CalculateDiagnose(int countQuestions, int countRightAnswers)
		{ 
			var diagnoses = GetDiagnoses();
			var percentRightAnswers = countRightAnswers * 100 / countQuestions;

			return diagnoses[percentRightAnswers / 20];
		}

		static int GetUserAnswer()
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



		static List<string> GetDiagnoses()
		{
			var diagnoses = new List<string>();
			diagnoses.Add("Идиот");
			diagnoses.Add("Кретин");
			diagnoses.Add("Дурак");
			diagnoses.Add("Нормальный");
			diagnoses.Add("Талант");
			diagnoses.Add("Гений");

			return diagnoses;
		}

	}

}