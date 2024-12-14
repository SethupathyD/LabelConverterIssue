namespace SfDataGridSample
{
    public partial class App : Application
    {
        public App()
        {
            this.UserAppTheme = AppTheme.Light;
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
