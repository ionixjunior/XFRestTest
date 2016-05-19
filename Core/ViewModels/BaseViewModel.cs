using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Core.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion

		protected void INotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null) 
			{
				PropertyChanged (this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

