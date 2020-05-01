using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XamarinBugs.Models;

namespace XamarinBugs.ViewModels
{
    public class ViewModel_Category : ViewModelBase
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties
        public ObservableCollection<Model_Categories> Categories { get; set; } = new ObservableCollection<Model_Categories>();
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_Category()
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
            this.Categories.Clear();

            for(int i = 0; i < 10; i++)
            {
                this.Categories.Add(new Model_Categories()
                {
                    Id = i,
                    CategoryName = "Category " + (i + 1)
                });
            }
        }
        #endregion
    }
}
