using WearRead.Services.Error_Informer;
using WearRead.Resources.Translations.Services.Error_Informer;
using WearRead.Services.Database_Controller;
using WearRead.Models.Local_DB;

namespace WearRead;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        InitServices();

        MainPage = new AppShell();
    }

    private void InitServices()
    {
        ErrorInformer.Init(Localisation.Error_Message_Title, Localisation.Error_Message_Okay, Localisation.Error_Message_Details);
        DBController.Init([ typeof(BookORM) ]);
    }
}