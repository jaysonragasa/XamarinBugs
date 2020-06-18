using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinBugs.ViewModels;

namespace XamarinBugs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var t = Task.Run(async () =>
            {
                await ((ViewModel_MainPage)this.BindingContext).RefreshData();
            });
            t.ConfigureAwait(false);
        }
    }
}
