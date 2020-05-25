using EmailRegistrationUi.EmailRegistrationWebService;
using EmailRegistrationUi.Services.Validator;
using EmailRegistrationUi.Views;
using Ninject;
using NLog;
using System.Windows;

namespace EmailRegistrationUi
{
    public partial class App : Application
    {
		private IKernel kernel;
		private WebService _webService;
		private EmailValidator _validator;
		private Logger _logger;
		public App()
		{
			kernel = new StandardKernel();
			var webService = kernel.Get<WebService>();
			var validator = kernel.Get<EmailValidator>();
			Logger logger = LogManager.GetCurrentClassLogger();
			_logger = logger;
			_webService = webService;
			_validator = validator;
		}
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			InitDependence();

			MainWindowView mwv = new MainWindowView(kernel, _webService, _validator, _logger);
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
			kernel.Bind<WebService>().ToSelf();
			kernel.Bind<EmailValidator>().ToSelf();
			kernel.Bind<Logger>().ToSelf();

			return this;
		}
	}
}
