using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuizME.Services.FormService;
using QuizME.Services.QuizService;

namespace QuizME
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			var host = CreateHostBuilder().Build();
			ServiceProvider = host.Services;
			
			Application.Run(ServiceProvider.GetRequiredService<MainForm>());
		}
		
		public static IServiceProvider ServiceProvider { get; private set; }

		static IHostBuilder CreateHostBuilder()
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) => 
				{
					services.AddSingleton<IFormService, FormService>();
					services.AddScoped<IQuizService, QuizService>();
					services.AddTransient<MainForm>();
				});
		}
	}
}