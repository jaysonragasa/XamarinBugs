using GalaSoft.MvvmLight.Ioc;

namespace XamarinBugs.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ViewModel_MainPage>();
        }

        public ViewModel_MainPage MainPage => SimpleIoc.Default.GetInstance<ViewModel_MainPage>();
    }
}
