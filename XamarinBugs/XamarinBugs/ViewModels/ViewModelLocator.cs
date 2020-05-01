using GalaSoft.MvvmLight.Ioc;

namespace XamarinBugs.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ViewModel_MainPage>();
            SimpleIoc.Default.Register<ViewModel_Category>();
        }

        public ViewModel_MainPage MainPage => SimpleIoc.Default.GetInstance<ViewModel_MainPage>();
        public ViewModel_Category Category => SimpleIoc.Default.GetInstance<ViewModel_Category>();
    }
}
