using System;
using System.Windows.Forms;
using QuizME.Models;

namespace QuizME.Forms
{
	public partial class QuizForm : Form
	{
		public QuizForm(Quiz quiz)
		{
			try
			{
				InitializeComponent();
				// Other initialization code...
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error initializing form: " + ex.Message);
			}
		}
	}
}