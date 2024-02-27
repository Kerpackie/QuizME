using System.Collections.Generic;

namespace QuizME.Models
{
	public class Quiz
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Topic { get; set; }
		public int Marks { get; set; }
		public string Instructions { get; set; }
		public List<Question> Questions { get; set; }
	}
}