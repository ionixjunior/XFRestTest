using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Core.ViewModels;

namespace Core.Views
{
	public partial class ContactView : ContentPage
	{
		public ContactView ()
		{
			InitializeComponent ();

			ContactViewModel viewModel = new ContactViewModel ();
			viewModel.LoadData ();
			BindingContext = viewModel;
		}
	}
}

