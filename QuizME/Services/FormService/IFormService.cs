using System.Windows.Forms;

namespace QuizME.Services.FormService
{
	public interface IFormService
	{
		void OpenForm<T>() where T : Form;
		void OpenFormWithArgument<T, TArg>(TArg arg) where T : Form;
		string OpenFile();
	}
}