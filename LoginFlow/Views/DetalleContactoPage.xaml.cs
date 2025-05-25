using LoginFlow.ViewModel;

namespace LoginFlow.Views;

public partial class DetalleContactoPage : ContentPage
{
	public DetalleContactoPage()
	{
		InitializeComponent();
        BindingContext = new DetalleContactoVM();
    }
    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}