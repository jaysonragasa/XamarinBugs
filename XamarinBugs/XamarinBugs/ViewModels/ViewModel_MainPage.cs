using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBugs.ViewModels
{
    public class ViewModel_MainPage : ViewModelBase
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties

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

        }
        #endregion
    }
}
