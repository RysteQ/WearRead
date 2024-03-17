using WearRead.Views.Home;

namespace WearRead;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}