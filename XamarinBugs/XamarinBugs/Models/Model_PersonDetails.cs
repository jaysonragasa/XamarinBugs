using GalaSoft.MvvmLight;

namespace XamarinBugs.Models
{
    public class Model_PersonDetails : ViewModelBase
    {
        private string _fullname = string.Empty;
        public string Fullname
        {
            get { return _fullname; }
            set { Set(nameof(Fullname), ref _fullname, value); }
        }
    }
}