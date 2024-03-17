using WearRead.Views.Home_Views;

namespace WearRead;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new OverviewView();
    }
}