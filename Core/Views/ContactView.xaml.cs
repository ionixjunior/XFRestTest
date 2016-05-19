using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Core.ViewModels;
using Core.Models;

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

		public void OnItemTapped(object sender, ItemTappedEventArgs args)
		{
			((ListView)sender).SelectedItem = null;
			ContactModel contactModel = (ContactModel)args.Item;
			Navigation.PushAsync (new ContactDetailView(contactModel.Id));
		}
	}
}

