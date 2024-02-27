using System.Collections.Generic;

namespace QuizME.Models.Questions
{
	public class MultipleChoice : Question
	{
		public List<string> Options { get; set; }
		public string Answer { get; set; }
	}
}