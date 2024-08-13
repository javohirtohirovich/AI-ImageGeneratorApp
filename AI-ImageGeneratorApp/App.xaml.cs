using AI_ImageGeneratorApp.Views;

namespace AI_ImageGeneratorApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashboardView();
        }
    }
}
