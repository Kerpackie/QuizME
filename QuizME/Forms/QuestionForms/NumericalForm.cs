using System;
using System.Windows.Forms;
using QuizME.Extensions;
using QuizME.Models;
using QuizME.Models.Questions;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms.QuestionForms
{
	public partial class NumericalForm : QuestionFormBase
	{
		private readonly IQuestionService _questionService;
		private readonly IQuizService _quizService;
		private readonly Quiz _quiz;
		
		public NumericalForm(IQuestionService questionService, IQuizService quizService, Quiz quiz) : 
			base(quizService, quiz, questionService)
		{
			_questionService = questionService;
			_quizService = quizService;
			_quiz = quiz;
			InitializeComponent();
		}
		
		protected override void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateNumericFormInputs(tbMarks, tbText, out var marks))
			{
				var question = CreateQuestion(marks);
				AddQuestionToQuiz(question);
				Close();
				MessageBox.Show("Question added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Invalid inputs. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private Numerical CreateQuestion(int marks)
		{
			//return _questionService.CreateNumericalQuestion()

			return null;
		}
	}
}