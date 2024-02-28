using System;
using System.Windows.Forms;
using QuizME.Models;
using QuizME.Services.QuestionService;
using QuizME.Services.QuizService;

namespace QuizME.Forms.QuestionForms
{
	public partial class QuestionFormBase : Form
	{
		private readonly IQuestionService _questionService;
		private readonly IQuizService _quizService;
		private readonly Quiz _quiz;
		
		protected Label lblText;
		protected TextBox tbText;
		/*protected Label lblAnswer;
		protected TextBox tbAnswer;*/
		protected Label lblMarks;
		protected TextBox tbMarks;
		protected Button btnCancel;
		protected Button btnSave;

		protected QuestionFormBase(IQuizService quizService, Quiz quiz, IQuestionService questionService)
		{
			_quizService = quizService;
			_quiz = quiz;
			_questionService = questionService;
			AddQuestionComponents();
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
		
		/*protected void DisableAnswerTextBox()
		{
			tbAnswer.Text = "N/A";
			tbAnswer.Enabled = false;
		}*/

		protected void AddQuestionComponents()
		{
			// Question Text
			lblText = new Label
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(31, 21),
				Name = "lblText",
				Size = new System.Drawing.Size(76, 23),
				TabIndex = 0,
				Text = "Text:"
			};
			
			tbText = new TextBox
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif", 
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(113, 18),
				Name = "tbText",
				Size = new System.Drawing.Size(552, 26),
				TabIndex = 1
			};
			
			//Answer
			/*lblAnswer = new Label
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(31, 63),
				Name = "lblText",
				Size = new System.Drawing.Size(76, 23),
				TabIndex = 2,
				Text = "Answer:"
			};

			tbAnswer = new TextBox
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(113, 60),
				Name = "tbAnswer",
				Size = new System.Drawing.Size(354, 26),
				TabIndex = 3
			};*/
			
			// Marks
			lblMarks = new Label
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(484, 63),
				Name = "lblMarks",
				Size = new System.Drawing.Size(61, 23),
				TabIndex = 4,
				Text = "Marks:"
			};
			
			tbMarks = new TextBox
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(551, 60),
				Name = "tbMarks",
				Size = new System.Drawing.Size(114, 29),
				TabIndex = 5
			};
			
			// Cancel Button
			btnCancel = new Button
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(684, 18),
				Name = "btnCancel",
				Size = new System.Drawing.Size(98, 27),
				TabIndex = 6,
				Text = "Cancel",
				UseVisualStyleBackColor = true
			};
			
			// Save Button

			btnSave = new Button
			{
				Font = new System.Drawing.Font("Microsoft Sans Serif",
					12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
					((byte) (0))),
				Location = new System.Drawing.Point(684, 60),
				Name = "btnSave",
				Size = new System.Drawing.Size(98, 27),
				TabIndex = 7,
				Text = "Add Question",
				UseVisualStyleBackColor = true
			};

			// Add components.
			Controls.Add(lblText);
			Controls.Add(tbText);
			/*Controls.Add(lblAnswer);
			Controls.Add(tbAnswer);*/
			Controls.Add(lblMarks);
			Controls.Add(tbMarks);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
		}
	}
}