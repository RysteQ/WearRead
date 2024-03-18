using WearRead.Services.Error_Informer;
using WearRead.Resources.Translations.Services.Error_Informer;
using WearRead.Services.Database_Controller;
using WearRead.Models.Local_DB;

using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace WearRead;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        RemoveUnderlines();
        InitServices();

        MainPage = new AppShell();
    }

    private void InitServices()
    {
        ErrorInformer.Init(Localisation.Error_Message_Title, Localisation.Error_Message_Okay, Localisation.Error_Message_Details);
        DBController.Init([ typeof(BookORM) ]);
    }

    private void RemoveUnderlines()
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
        {
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
        });
    }
}