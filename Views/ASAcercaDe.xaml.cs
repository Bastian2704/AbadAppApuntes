namespace AbadAppApuntes.Views;

public partial class ASAcercaDe : ContentPage
{
	public ASAcercaDe()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.SAAcercaDE about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}