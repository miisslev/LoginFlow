using LoginFlow.ViewModel;

namespace LoginFlow.Views;

public partial class ContactosPage : ContentPage
{
	public ContactosPage()
	{
		InitializeComponent();
		BindingContext = new ContactosVM();
	}
    private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Contacto contactoSeleccionado)
        {
            await Shell.Current.GoToAsync(nameof(DetalleContactoPage), new Dictionary<string, object>
            {
                { "Contacto", contactoSeleccionado }
            });
        }
       ((CollectionView)sender).SelectedItem = null;
    }
}
