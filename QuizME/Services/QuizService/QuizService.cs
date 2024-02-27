using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using QuizME.Models;

namespace QuizME.Services.QuizService
{
	public class QuizService : IQuizService
	{
		public Quiz CreateQuiz(string name, string description, string topic, int marks, string instructions)
		{
			// Create a new Quiz, using information passed from the form.
			
			var quiz = new Quiz
			{
				Name = name,
				Description = description,
				Topic = topic,
				Marks = marks,
				Instructions = instructions
			};
			
			return quiz;
		}

		public Quiz UpdateQuiz(Quiz quiz, string name, string description, string topic, int marks, string instructions)
		{
			// Update the Quiz with the new information passed from the form.
			
			quiz.Name = name;
			quiz.Description = description;
			quiz.Topic = topic;
			quiz.Marks = marks;
			quiz.Instructions = instructions;
			
			return quiz;
		}

		public void DeleteQuiz(Quiz quiz)
		{
			throw new System.NotImplementedException();
		}

		public Quiz LoadQuizFromFile(string path)
		{
			var json = File.ReadAllText(path);
			var quiz = JsonConvert.DeserializeObject<Quiz>(json);
			
			return quiz;

		}

		public void SaveQuizToFile(Quiz quiz, string path)
		{
			var json = JsonConvert.SerializeObject(quiz);
			File.WriteAllText(path + ".quiz", json);
		}

		public void DeleteQuizFromFile(string path)
		{
			File.Delete(path);
		}
	}
}