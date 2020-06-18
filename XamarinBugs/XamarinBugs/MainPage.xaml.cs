using Microsoft.AspNetCore.SignalR.Client;

using OmniGoo.Business.Services.Client;
using OmniGoo.Common.Services;

using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinBugs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        BusinessClientServiceClient BusinessClientServiceClient = new BusinessClientServiceClient(null, null);
        BusinessUserServiceClient BusinessUserServiceClient = new BusinessUserServiceClient(null, null);
        ClientModelServiceClient ClientModelServiceClient = new ClientModelServiceClient(null, null);
        ConversationServiceClient ConversationServiceClient = new ConversationServiceClient(null, null);
        DailyMealServiceClient DailyMealServiceClient = new DailyMealServiceClient(null, null);
        MessageServiceClient MessageServiceClient = new MessageServiceClient(null, null);
        WajbatiOrderServiceClient WajbatiOrderServiceClient = new WajbatiOrderServiceClient(null, null);

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
