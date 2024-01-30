namespace GeniyIdiot.Common
{
	public class CalculateDiagnose
	{

		public static string DiagnoseCalculate(int countQuestions, int countRightAnswers)
		{
			var diagnoses = GetDiagnoses();
			var percentRightAnswers = countRightAnswers * 100 / countQuestions;

			return diagnoses[percentRightAnswers / 20];
		}



		public static List<string> GetDiagnoses()
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