using AbadAppApuntes.Models;

namespace AbadAppApuntes.Views;

public partial class SATodasNotas : ContentPage
{
	public SATodasNotas()
	{
		InitializeComponent();
        BindingContext = new Models.SATodasNotas();
    }

    protected override void OnAppearing()
    {
        ((Models.SATodasNotas)BindingContext).LoadNotes();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SANotas));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (Models.SANote)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(SANote)}?{nameof(SANotas.ItemId)}={note.Filename}");

          
        }
    }
}