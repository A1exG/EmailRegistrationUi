using EmailRegistrationUi.Views;
using System.Windows;

namespace EmailRegistrationUi
{
    public partial class App : Application
    {
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			MainWindowView mwv = new MainWindowView();
			mwv.Show();
			mwv.WindowStartupLocation = WindowStartupLocation.CenterScreen;

			Application.Current.MainWindow.Closed += (s, a) =>
			{
				Shutdown();
			};
		}
	}
}
