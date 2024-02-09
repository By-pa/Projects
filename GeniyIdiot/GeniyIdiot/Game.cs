using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
	public class Game
	{
		User user;
		List<Question> questions;
		Question currentQuestion;
		int questionNumber = 1;
		int countQuestion;

		public Game(User user)
		{
			this.user = user;
			questions = QuestionsStorage.GetAll();
			countQuestion = questions.Count;
		}

		public Question GetNextQuestion()
		{
			var random = new Random();
			var randomQuestionIndex = random.Next(0, questions.Count);
			currentQuestion = questions[randomQuestionIndex];

			questionNumber++;

			return currentQuestion;
		}

		public void AcceptAnswer(int userAnswer)
		{
			var rightAnswer = currentQuestion.Answer;

			if(userAnswer == rightAnswer)
			{
				user.AcceptRightAnswer();
			}

			questions.Remove(currentQuestion); 
		}
		
		public string GetQuestionNumberText()
		{
			return "Вопрос №" + questionNumber;	
		}

		public bool End()
		{
			return questions.Count == 0;
		}
		public string CalculateDiagnose()
		{
			var diagnose = DiagnoseCalculator.Calculate(countQuestion, user.CountRightAnswers);
			user.Diagnose = diagnose;
			UserResultsStorage.Append(user);

			return user.Name + ", твой диагноз: " + user.Diagnose;
		}
	}
}
