namespace QuizME.Models.Questions
{
	public class Numerical : Question
	{
		public int MinX { get; set; } = 0;
		public int MaxX { get; set; }
		public int MinY { get; set; } = 0;
		public int MaxY { get; set; }
		public char Operator { get; set; }

		public int Answer { get; set; }
	}
}