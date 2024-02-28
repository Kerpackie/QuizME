using System;
using System.Linq;
using System.Windows.Forms;
using QuizME.Extensions;
using QuizME.Models;
using QuizME.Models.Questions;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms.QuestionForms
{
	public partial class TrueFalseForm : QuestionForm
	{
		private readonly IQuestionService _questionService;
		private readonly IQuizService _quizService;
		private readonly Quiz _quiz;

		public TrueFalseForm(IQuestionService questionService, IQuizService quizService, Quiz quiz) : base(questionService, quizService, quiz)
		{
			_questionService = questionService;
			_quizService = quizService;
			_quiz = quiz;
			
			InitializeComponent();
		}
		
		protected override void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateTrueFalseFormInputs(tbMarks, tbText, rbTrue, rbFalse, out var marks))
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
		
		private TrueFalse CreateQuestion(int marks)
		{
			var answer = gbTrueFalse.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;
			return _questionService.CreateTrueFalseQuestion(marks, tbText.Text, answer);
		}
		
		
	}
}