using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Core.ViewModels;

namespace Core.Views
{
	public partial class ContactDetailView : ContentPage
	{
		public ContactDetailView (string id)
		{
			InitializeComponent ();

			ContactDetailViewModel viewModel = new ContactDetailViewModel ();
			viewModel.LoadData (id);
			BindingContext = viewModel;
		}
	}
}

