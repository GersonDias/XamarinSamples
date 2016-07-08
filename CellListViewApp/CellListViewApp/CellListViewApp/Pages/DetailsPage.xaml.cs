using System;
using System.Collections.Generic;
using CellListViewApp.ViewModel;
using Xamarin.Forms;

namespace CellListViewApp
{
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage(string details)
		{
			InitializeComponent();

			BindingContext = new DetailsViewModel(details);
		}
	}
}

