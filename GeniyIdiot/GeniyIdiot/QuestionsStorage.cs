using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
	public class QuestionsStorage
	{
		public static string Path = "questions.json";
		public static List<Question> GetAll()
		{
			var questions = new List<Question>();

			if (FileProvider.Exists(Path))
			{
				var value = FileProvider.GetValue(Path);
				questions = JsonConvert.DeserializeObject<List<Question>>(value);
			}
			else
			{
				questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
				questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
				questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
				questions.Add(new Question("Укол делают каждые пол часа, сколько нужно минут для трех уколов?", 60));
				questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
				SaveQuestions(questions);
			}

			return questions;

		}

		private static void SaveQuestions(List<Question> questions)
		{
			var jsonData = JsonConvert.SerializeObject(questions);
			FileProvider.Replace(Path, jsonData);
		}

		public static void Add(Question newQuestion)
		{
			var questoins = GetAll();
			questoins.Add(newQuestion);
			SaveQuestions(questoins);
		}

		public static void Remove(string text)
		{
			var questions = GetAll();

			for (int i = 0; i < questions.Count; i++)
			{
				if (questions[i].Text == text)
				{
					questions.RemoveAt(i);
				}
			}
			SaveQuestions(questions);
		}
	}

}