using System.Runtime.CompilerServices;

namespace WearRead.Services.Error_Informer;

public static class ErrorInformer
{
    public static void Init(string error_message_title_caption, string error_message_okay_caption, string error_message_details_caption)
    {
        if (initialised)
            throw new Exception("The Init method can only be called once");

        initialised = true;
    }

    public static async void InformSimple(string friendly_message, Exception ex)
    {
        CheckInitialisation();

        if (await Shell.Current.DisplayAlert(error_message_title_caption_internal, friendly_message, error_message_details_caption, error_message_okay_caption))
            await Shell.Current.DisplayAlert(error_message_title_caption_internal, $"{ex.Message}\n{ex.InnerException}", error_message_okay_caption);
    }

    public static async void InformAdvanced(string friendly_message, Exception ex, string view_model, [CallerMemberName] string method = "")
    {
        CheckInitialisation();

        if (await Shell.Current.DisplayAlert(error_message_title_caption_internal, friendly_message, error_message_details_caption, error_message_okay_caption))
            await Shell.Current.DisplayAlert(error_message_title_caption_internal, $"{view_model}-{method}: {ex.Message}\n{ex.InnerException}", error_message_okay_caption);
    }

    private static void CheckInitialisation()
    {
        if (initialised == false)
            throw new Exception("You must first call the Init method");
    }

    private static string error_message_title_caption_internal = string.Empty;
    private static string error_message_okay_caption = string.Empty;
    private static string error_message_details_caption = string.Empty;
    private static bool initialised;
}