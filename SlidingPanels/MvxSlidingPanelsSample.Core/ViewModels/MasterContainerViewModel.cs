using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvxSlidingPanelsSample.Core.ViewModels
{
    public class MasterContainerViewModel : MvxViewModel
    {
		private string _displayName;
		public string DisplayName
		{
			get
			{
				return _displayName;
			}
			set
			{
				_displayName = value;
				RaisePropertyChanged(() => DisplayName);
			}
		}

		public MasterContainerViewModel()
		{
			DisplayName = "Default Master";
		}

		public override void Start ()
		{
			base.Start();
			//ShowViewModel(typeof(LeftPanelViewModel));
			ShowViewModel(typeof(RightPanelViewModel));
			ShowViewModel(typeof(BottomPanelViewModel));
			ShowViewModel(typeof(FirstViewModel));
		}
    }
}

