using EmailRegistrationUi.Services.Validator;
using EmailRegistrationUi.Views;
using Ninject;
using System.Windows;

namespace EmailRegistrationUi
{
    public partial class App : Application
    {
		private IKernel kernel;
		public App()
		{
			kernel = new StandardKernel();
		}
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			InitDependence();

			MainWindowView mwv = new MainWindowView(kernel);
			mwv.Show();
			mwv.WindowStartupLocation = WindowStartupLocation.CenterScreen;

			Application.Current.MainWindow.Closed += (s, a) =>
			{
				Shutdown();
			};
		}
		public App InitDependence()
		{
			kernel.Bind<IValidator>().To<Validator>().InSingletonScope();
			kernel.Bind<EmailRegistrationWebService.WebService>().ToSelf();
			return this;
		}
	}
}
