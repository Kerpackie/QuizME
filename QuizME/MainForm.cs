using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizME.Forms;
using QuizME.Models;
using QuizME.Services.FormService;
using QuizME.Services.QuizService;

namespace QuizME
{
	public partial class MainForm : Form
	{
		private readonly IQuizService _quizService;
		private readonly IFormService _formService;
		
		public MainForm(IQuizService quizService, IFormService formService)
		{
			_quizService = quizService;
			_formService = formService;
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLoadQuiz_Click(object sender, EventArgs e)
		{
			var loadQuiz = _formService.OpenFile();

			var quiz = _quizService.LoadQuizFromFile(loadQuiz);

			_formService.OpenFormWithArgument<QuizForm, Quiz>(quiz);
		}

		private void btnNewQuiz_Click(object sender, EventArgs e)
		{
			var quiz = _quizService.CreateQuiz();
			
			_formService.OpenFormWithArgument<QuizForm, Quiz>(quiz);
		}
	}
}