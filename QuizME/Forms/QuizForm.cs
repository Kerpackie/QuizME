using System;
using System.Windows.Forms;
using QuizME.Models;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms
{
	public partial class QuizForm : Form
	{
		private readonly IQuizService _quizService;
		private readonly Quiz _quiz;
		public QuizForm(Quiz quiz, IQuizService quizService)
		{
			_quiz = quiz;
			try
			{
				_quizService = quizService;
				InitializeComponent();
				InitDataGridQuestions();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error initializing form: " + ex.Message);
			}
		}

		private void InitDataGridQuestions()
		{
			dgvQuestions.AutoGenerateColumns = false;
			dgvQuestions.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Type",
				HeaderText = "Question Type",
				Name = "QuestionType"
			});
			dgvQuestions.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = "Text",
				HeaderText = "Question Text",
				Name = "QuestionText"
			});
			dgvQuestions.DataSource = _quiz.Questions;
			dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
		
	}
}