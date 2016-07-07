using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellListViewApp.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CellListViewApp.ViewModel
{
    public class MainViewModel
    {
        private ContentPage _page;

        public ObservableCollection<Disco> Discos
        {
            get; set;
        }

        public void Item_Clicked(MenuItem menuItem)
        {
                var disco = menuItem?.CommandParameter as Disco;

                if (disco != null)
                {
                    if (menuItem.IsDestructive)
                    {
                        Discos.Remove(disco);
                    }
                    else
                    {
                        _page.DisplayAlert(disco.Title, disco.Description, "OK");
                    }
                }
        }

        public MainViewModel(ContentPage page)
        {
            this.Discos = new ObservableCollection<Disco>()
            {
                new Disco() { Title = "Vira e Mexe", Description = "Primeiro CD do Luis Gonzaga", Image = "http://www.turminha.mpf.mp.br/imagens/ilustracoes-geral/100-anos-de-Luiz-Gonzaga.jpg", Selected=true },
                new Disco() { Title = "Dark side of the moon", Description = "CD Clássico do PinkFloid", Image="https://3.bp.blogspot.com/-kFRa2zJSmCQ/Uiz66rlQ-KI/AAAAAAAACLI/rCkHLOehsko/s650/dark-side-of-the-moon-new-yeah.jpg", Selected=false },
                new Disco() { Title = "Nevermind", Description = "Melhor do Nirvana", Image = "http://s3.amazonaws.com/rapgenius/3d2a123ddc312423225755a14fe7db2d.jpg", Selected = true}
            };

            _page = page; 
        }
    }
}
