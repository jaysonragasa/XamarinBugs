
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBugs.ViewModels;

namespace XamarinBugs.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();

            ((ViewModelLocator)this.BindingContext).Category.RefreshData();
        }
    }
}