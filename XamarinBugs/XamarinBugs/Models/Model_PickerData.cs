using GalaSoft.MvvmLight;

namespace XamarinBugs.Models
{
    public class Model_PickerData : ViewModelBase
    {
        public string Id { get; set; } = null;

        private string _DisplayName = string.Empty;
        public string DisplayName
        {
            get { return _DisplayName; }
            set { Set(nameof(DisplayName), ref _DisplayName, value); }
        }
    }
}
