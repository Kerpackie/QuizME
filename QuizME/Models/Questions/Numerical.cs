using System;

namespace QuizME.Models.Questions
{
	public class Numerical : Question
	{
		public int MinX { get; set; } = 0;
		public int MaxX { get; set; }
		public int MinY { get; set; } = 0;
		public int MaxY { get; set; }
		public int XVal { get; private set; }
		public int YVal { get; private set; }
		public string Operator { get; set; }

		public int Answer { get; set; }

		public Numerical(int mark, int x, int y, string operation, string text)
		{
			Mark = mark;
			XVal = x;
			YVal = y;
			Operator = operation;
			Text = text;
			GenerateAnswer();
		}

		private void GenerateAnswer()
		{
			switch (Operator)
			{
				case "+":
					Answer = XVal + YVal;
					break;
				case "-":
					Answer = XVal - YVal;
					break;
				case "*":
					Answer = XVal * YVal;
					break;
				case "/":
					Answer = XVal / YVal;
					break;
				default:
					break;
			}
		}
	}
}