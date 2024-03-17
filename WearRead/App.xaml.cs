using WearRead.Views.Overview;

namespace WearRead;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new OverviewView();
    }
}