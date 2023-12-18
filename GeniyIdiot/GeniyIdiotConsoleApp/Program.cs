namespace GeniyIdiotConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{




				Console.WriteLine("Здравствуйте! Как Тебя зовут?)");
				string userName = Console.ReadLine();

				int countQuestions = 5;
				string[] questions = GetQuestions(countQuestions);
				int[] Answers = GetAnswer(countQuestions);

				int countRightAnswers = 0;

				Random random = new Random();


				//Алгоритм перемешивания "Тасование Фишера — Йетса"
				for (int i = countQuestions - 1; i >= 1; i--)
				{
					int index = random.Next(0, i);

					string tempQuestions = questions[index];
					questions[index] = questions[i];
					questions[i] = tempQuestions;

					int tempAnswers = Answers[index];
					Answers[index] = Answers[i];
					Answers[i] = tempAnswers;
				}



				for (int i = 0; i < countQuestions; i++)
				{
					Console.WriteLine($"Вопрос номер: {i + 1}");

					Console.WriteLine(questions[i]);

					int userAnswer = GetUserAnswer();

					if (userAnswer == Answers[i])
					{
						countRightAnswers++;
					}

				}

				Console.WriteLine("Количество правильных ответов: " + countRightAnswers);

				string[] diagnoses = GetDiagnoses();


				Console.WriteLine(userName + ", Ваш диагноз: " + diagnoses[countRightAnswers]);

				bool userChoise = GetUserChoise("Хотите начать сначала?");
				if (userChoise == false)
				{
					break;
				}
				
			}
        }

		private static int GetUserAnswer()
		{
			while (true)
			{
				try
				{
					return Convert.ToInt32(Console.ReadLine());
				}
				catch(FormatException)
				{
                    Console.WriteLine("Введите число!");
                } 
				catch(OverflowException)
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
				string userInput = Console.ReadLine();

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
		static string[] GetQuestions(int countQuestions)
		{
			string[] questions = new string[countQuestions];
			questions[0] = "Сколько будет два плюс два умноженное на два?";
			questions[1] = "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?";
			questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
			questions[3] = "Укол делают каждыйе пол часа, сколько нужно минут для трех уколов?";
			questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";

			return questions;
		}

		static void Shuffle(string[] questions)
		{
			Random rand = new Random();

			for (int i = questions.Length - 1; i >= 1; i--)
			{
				int j = rand.Next(i + 1);
				string tmp = questions[j];
				questions[j] = questions[i];

			}
		}	
		static string[] GetDiagnoses()
		{
			string[] diagnoses = new string[6];
			diagnoses[0] = "Идиот";
			diagnoses[1] = "Кретин";
			diagnoses[2] = "Дурак";
			diagnoses[3] = "Нормальный";
			diagnoses[4] = "Талант";
			diagnoses[5] = "Гений";

			return diagnoses;
		}

		static int[] GetAnswer(int countQuestions)
		{
			int[] answers = new int[countQuestions];
			answers[0] = 6;
			answers[1] = 9;
			answers[2] = 25;
			answers[3] = 60;
			answers[4] = 2;
			return answers;
		}
		
	}
}