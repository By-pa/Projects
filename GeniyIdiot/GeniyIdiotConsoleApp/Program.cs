using System.IO;
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

				
				var questions = GetQuestions();
				var Answers = GetAnswer();
				var countQuestions = questions.Count; 
				var countRightAnswers = 0;

				Random random = new Random();


				for (int i = 0; i < countQuestions; i++)
				{
					Console.WriteLine($"Вопрос номер: {i + 1}");
					var randomQuestionIndex = random.Next(0, questions.Count);
					Console.WriteLine(questions[randomQuestionIndex]);

					var userAnswer = GetUserAnswer();
					var rightAnswer = Answers[randomQuestionIndex];

					if (userAnswer == rightAnswer)
					{
						countRightAnswers++;
					}
					questions.RemoveAt(randomQuestionIndex);
					Answers.RemoveAt(randomQuestionIndex);

				}

				Console.WriteLine("Количество правильных ответов: " + countRightAnswers);

				var diagnose = CalculateDiagnose(countQuestions, countRightAnswers);

				Console.WriteLine(userName + ", Ваш диагноз: " + diagnose);

				SaveUserResult(userName, countRightAnswers, diagnose);

				var userChoise = GetUserChoise("Хотите посмотреть предыдущие результаты игры");
				if(userChoise)
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

		static void ShowUserResults()
		{
			StreamReader reader = new StreamReader("userResults.txt", Encoding.UTF8);

            Console.WriteLine("{0,-20} {1,10} {2,10}", "Имя", "Кол-во правильных ответов", "Диагноз");
            while(!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				var values = line.Split("#");
				var name = values[0];
				var countRightAnswers  = Convert.ToInt32(values[1]);
				var diagnose = values[2];

				Console.WriteLine("{0,-20} {1,10} {2,10}", name, countRightAnswers, diagnose);
			}
			reader.Close();



		}

		static void SaveUserResult(string userName, int countRightAnswers, string diagnose)
		{
			var value = $"{userName}#{countRightAnswers}#{diagnose}";
			AppendToFile("userResults.txt", value);
		}

		static void AppendToFile(string fileName, string value)
		{
			var writer = new StreamWriter(fileName, true, Encoding.UTF8);

			writer.WriteLine(value);
			writer.Close();
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
			static List<string> GetQuestions()
			{
				var questions = new List<string>();
				questions.Add("Сколько будет два плюс два умноженное на два?");
				questions.Add("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?");
				questions.Add("На двух руках 10 пальцев. Сколько пальцев на 5 руках?");
				questions.Add("Укол делают каждыйе пол часа, сколько нужно минут для трех уколов?");
				questions.Add("Пять свечей горело, две потухли. Сколько свечей осталось?");

				return questions;
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

			static List<int> GetAnswer()
			{
				var answers = new List<int>();
				answers.Add(6);
				answers.Add(9);
				answers.Add(25);
				answers.Add(60);
				answers.Add(2);
				return answers;
			}
		}
		
}