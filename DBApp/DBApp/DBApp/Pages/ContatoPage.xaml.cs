using DBApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DBApp.Pages
{
    public partial class ContatoPage : ContentPage
    {
        public ContatoPage()
        {
            InitializeComponent();

            BindingContext = new ContatoViewModel();
        }
    }
}
