using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using XamarinBugs.Models;

namespace XamarinBugs.ViewModels
{
    public class ViewModel_MainPage : ViewModelBase
    {
        #region events

        #endregion

        #region vars
        int _callIndex = 0;
        #endregion

        #region properties
        public ObservableCollection<Model_PickerData> PickerSource { get; set; } = new ObservableCollection<Model_PickerData>();

        private Model_PickerData _SelectedItem = new Model_PickerData();
        public Model_PickerData SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                Set(nameof(SelectedItem), ref _SelectedItem, value);

                this._callIndex++;

                Debug.WriteLine($"DEBUG> call index{this._callIndex} | SelectedItem called. Is value null? " + (value == null ? "YES" : "NO") );
            }
        }
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_MainPage()
        {
            InitCommands();
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
            this.PickerSource.Add(new Model_PickerData()
            {
                Id = "0",
                DisplayName = "zero"
            });

            this.PickerSource.Add(new Model_PickerData()
            {
                Id = "1",
                DisplayName = "one"
            });

            this.PickerSource.Add(new Model_PickerData()
            {
                Id = "2",
                DisplayName = "two"
            });

            this.PickerSource.Add(new Model_PickerData()
            {
                Id = "3",
                DisplayName = "three"
            });

            this.SelectedItem = this.PickerSource[3];
        }
        #endregion
    }
}
