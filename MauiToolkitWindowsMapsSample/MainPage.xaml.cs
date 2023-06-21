using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiToolkitWindowsMapsSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var p = new Pin()
        {

            Location = new Location(50, 6),
            Label = "Subscribe to this channel from this location",
            Address = "My Locationroad 1337"
        };

        p.MarkerClicked += P_MarkerClicked;

        myMap.Pins.Add(p);

		myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Location(50, 6), Distance.FromKilometers(10)));
    }

    private void P_MarkerClicked(object sender, PinClickedEventArgs e)
    {
        DisplayAlert("Clicked", "Subscribe", "OK");
    }
}

