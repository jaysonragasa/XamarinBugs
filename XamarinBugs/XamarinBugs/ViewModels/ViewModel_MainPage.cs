using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamarinBugs.Models;

namespace XamarinBugs.ViewModels
{
    public class ViewModel_MainPage : ViewModelBase
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties
        public ObservableCollection<Model_PersonDetails> PersonCollection { get; set; } = new ObservableCollection<Model_PersonDetails>();
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_MainPage()
        {
            InitCommands();

            // used only in UWP & WPF
            // or anything that supports design time updates
            if (base.IsInDesignMode)
            {
                DesignData();
            }
            else
            {
                RuntimeData();
            }
        }
        #endregion

        #region command methods

        #endregion

        #region methods
        void InitCommands()
        {

        }

        void DesignData()
        {

        }

        void RuntimeData()
        {

        }

        public async Task RefreshData()
        {
            this.PersonCollection.Clear();
            this.PersonCollection.Add(new Model_PersonDetails()
            {
                Fullname = "Jose Rizal"
            });
            this.PersonCollection.Add(new Model_PersonDetails()
            {
                Fullname = "Ramon Magsaysay"
            });
        }
        #endregion
    }
}
