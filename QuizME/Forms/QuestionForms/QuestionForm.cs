﻿using System;
using System.Windows.Forms;
using QuizME.Models;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms.QuestionForms
{
	public partial class QuestionForm : Form
	{
		private readonly IQuestionService _questionService;
		private readonly IQuizService _quizService;
		private readonly Quiz _quiz;
		
		public QuestionForm(IQuestionService questionService, IQuizService quizService, Quiz quiz)
		{
			_questionService = questionService;
			_quizService = quizService;
			_quiz = quiz;
			InitializeComponent();
			
			btnCancel.Click += (sender, e) => Close();
			btnSave.Click += btnSave_Click;
		}

		protected virtual void btnSave_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		
		protected virtual void AddQuestionToQuiz(Question question)
		{
			_quizService.AddQuestionToQuiz(_quiz, question);
		}
	}
}