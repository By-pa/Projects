using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace GeniyIdiot.Common
{
	public class UserResultsStorage
	{

		public static void Append(User user)
		{
			var usersResults = GetUserResults();
			usersResults.Add(user);
			Save(usersResults);
		}


		public static List<User> GetUserResults()
		{

			if(!FileProvider.Exists("userResults.json"))
			{
				return new List<User>();
			}

			var fileData = FileProvider.GetValue("userResults.json");
			var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
			return userResults;
		}
		static void Save(List<User> usersResults)
		{
			var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
			FileProvider.Replace("userResults.json", jsonData);
		}
	}

}