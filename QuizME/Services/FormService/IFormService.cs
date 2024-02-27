using System.Windows.Forms;

namespace QuizME.Services.FormService
{
	public interface IFormService
	{
		void OpenForm<T>() where T : Form;
		string OpenFile();
	}
}