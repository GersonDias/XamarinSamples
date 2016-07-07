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

        public void Item_Click(object sender, EventArgs e)
        {
            _viewModel.Item_Clicked((MenuItem)sender);
        }
    }
}
