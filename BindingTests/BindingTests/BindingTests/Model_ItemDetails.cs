using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BindingTests
{
    public class Model_ItemDetails
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
        public Model_ItemDetails()
        {
            InitCommands();

            /*
			// used only in UWP & WPF
			// or anything that supports design time updates
			if(base.IsInDesignMode)
			{
				DesignData();
			}
			else
			{
				RuntimeData();
			}
			*/
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