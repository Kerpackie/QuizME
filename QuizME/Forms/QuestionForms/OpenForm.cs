using System;
using System.Windows.Forms;
using QuizME.Extensions;
using QuizME.Models;
using QuizME.Models.Questions;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms.QuestionForms
{
	public partial class OpenForm : QuestionForm
	{
		private readonly IQuestionService _questionService;
		private readonly IQuizService _quizService;
		private readonly Quiz _quiz;
		
		public OpenForm(IQuestionService questionService, IQuizService quizService, Quiz quiz) : 
			base(questionService, quizService, quiz)
		{
			_questionService = questionService;
			_quizService = quizService;
			_quiz = quiz;
			InitializeComponent();
		}
		
		protected override void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateOpenFormInputs(tbMarks, tbText, rtbNotes, out var marks))
			{
				var question = CreateQuestion(marks);
				AddQuestionToQuiz(question);
				Close();
				MessageBox.Show("Question added successfully.", "Success", 
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Invalid inputs. Please check your inputs and try again.", "Error", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private Open CreateQuestion(int marks)
		{
			return _questionService.CreateOpenQuestion(marks, tbText.Text, rtbNotes.Text);
		}
	}
}