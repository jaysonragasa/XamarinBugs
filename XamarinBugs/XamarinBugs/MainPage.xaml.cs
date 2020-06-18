using Microsoft.AspNetCore.SignalR.Client;

using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinBugs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        HubConnection _hub;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            _hub = new HubConnectionBuilder()
                .WithUrl(
                    $"http://192.168.0.100:44373/WmpHub",
                    Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets
                )
                .Build();

            await _hub.StartAsync();

            if(_hub.State == HubConnectionState.Connected)
            {

            }
        }
    }
}
