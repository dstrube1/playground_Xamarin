using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace FunFlacts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var np = new NavigationPage(new MainPage());

            np.On<Windows>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            MainPage = np;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
