using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Core.ViewModels;
using Core.Models;

namespace Core.Views
{
	public partial class ContactView : ContentPage
	{
		private ContactViewModel _viewModel { get; set; }

		public ContactView ()
		{
			InitializeComponent ();

			_viewModel = new ContactViewModel ();
			BindingContext = _viewModel;
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			_viewModel.LoadData ();
		}

		public void OnItemTapped(object sender, ItemTappedEventArgs args)
		{
			((ListView)sender).SelectedItem = null;
			ContactModel contactModel = (ContactModel)args.Item;
			Navigation.PushAsync (new ContactDetailView(contactModel.Id));
		}

		public void OnAdd(object sender, EventArgs args)
		{
			Navigation.PushAsync (new ContactDetailView(null));
		}
	}
}

