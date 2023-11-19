using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MauiToolkitWindowsMapsSample;

public partial class MainPage : ContentPage
{
  void OnMapClicked(object sender, MapClickedEventArgs e)
  {
    System.Diagnostics.Debug.WriteLine($"MapClick: {e.Location.Latitude}, {e.Location.Longitude}");

    var p = new Pin()
    {

      Location = e.Location,
      Label = "A pin",
      Address = "A place"
    };
    myMap.Pins.Add(p);
  }

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

