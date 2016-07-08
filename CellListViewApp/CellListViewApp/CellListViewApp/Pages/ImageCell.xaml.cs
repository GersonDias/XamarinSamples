using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellListViewApp.ViewModel;
using Xamarin.Forms;

namespace CellListViewApp.Pages
{
    public partial class ImageCell : ContentPage
    {
		MainViewModel _viewModel;

        public ImageCell()
        {
            InitializeComponent();
		
			_viewModel = new MainViewModel(this);

			BindingContext = _viewModel;
		}

		public void MenuItem_Clicked(object sender, EventArgs e)
		{
			_viewModel.MenuItem_Clicked((MenuItem)sender);
		}

		public void Disco_Tapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			_viewModel.Disco_Clicked((Model.Disco)((ListView)sender).SelectedItem);
		}
    }
}
