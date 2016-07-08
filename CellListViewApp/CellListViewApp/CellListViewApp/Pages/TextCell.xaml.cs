using CellListViewApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CellListViewApp.Pages
{
    public partial class TextCell : ContentPage
    {
        private MainViewModel _viewModel;

        public TextCell()
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
