using LoginFlow.ViewModel;

namespace LoginFlow.Views;

public partial class CrearContactoPage : ContentPage
{
	public CrearContactoPage()
	{
		InitializeComponent();
        BindingContext = new CrearContactoVM();
    }
}