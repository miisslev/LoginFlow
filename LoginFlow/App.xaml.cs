using LoginFlow.Datos;
#if __ANDROID__
using Android.Content.Res;

using Microsoft.Maui.Controls.Compatibility.Platform.Android;

#endif
namespace LoginFlow;

public partial class App : Application
{
    public static ContactoDatabase ContactoDatabase { get; private set; }
    public App()
    {

        InitializeComponent();

        MainPage = new AppShell();

        ContactoDatabase = new ContactoDatabase();
        _ = NavegarSegunEstadoAsync();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderLine", (handler, view) =>
        {
#if __ANDROID__
        //    (handler.PlatformView as Android.Views.View).SetBackgroundColor(Microsoft.Maui.Graphics.Colors.Transparent.ToAndroid());
#endif
        });
    }
    private async Task NavegarSegunEstadoAsync()
    {
        if (Preferences.ContainsKey("UsuarioActualId"))
        {
            await Shell.Current.GoToAsync("//home");
        }
        else
        {
            await Shell.Current.GoToAsync("//login");
        }
    }
}
