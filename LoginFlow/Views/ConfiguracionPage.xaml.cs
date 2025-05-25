using LoginFlow.ViewModel;

namespace LoginFlow.Views;

public partial class ConfiguracionPage : ContentPage
{
    public ConfiguracionPage()
    {
        InitializeComponent();
        BindingContext = new ConfiguracionVM();
    }
}