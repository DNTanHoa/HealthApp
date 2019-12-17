using Xamarin.Forms;
using Xamarin.Essentials;
using System;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace HealthApp.Views
{
    public partial class MapScreenView : ContentPage
    {
        public MapScreenView()
        {
            InitializeComponent();
            GetDeviceLocation().GetAwaiter();
        }

        public async Task GetDeviceLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                var position = new Position(location.Latitude, location.Longitude);

                var pin = new Pin()
                {
                    Position = position,
                    Label = "Hiện Tại"
                };

                routeMap.Pins.Add(pin);

                routeMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(1)));
            }
            catch(FeatureNotSupportedException fnsEx)
            {
                //TODO: handle not supported location on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                //TODO: handle not enabled location on device exception
            }
            catch (PermissionException pEx)
            {
                //TODO: Handle permission location exception
            }
            catch (Exception ex)
            {
                //TODO: Unable to get location
            }
        }
    }
}
