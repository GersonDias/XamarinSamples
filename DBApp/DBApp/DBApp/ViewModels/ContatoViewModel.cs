using DBApp.Infra;
using DBApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DBApp.ViewModels
{
    public class ContatoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _telefone;
        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
                OnPropertyChanged(nameof(Telefone));
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private List<Contato> _lista = new List<Contato>();
        public List<Contato> Lista
        {
            get
            {
                return _lista;
            }
            set
            {
                _lista = value;
                OnPropertyChanged(nameof(Lista));
            }
        }

        public ICommand btnSalvar_Clicked
        {
            get; set;
        }

        public ContatoViewModel()
        {
            using (var dados = new AcessoDados<Contato>())
            {
                this.Lista = dados.Listar();
            }

            btnSalvar_Clicked = new Command(o =>
            {
                var contato = new Contato()
                {
                    Name = this.Name,
                    Email = this.Email,
                    Telefone = this.Telefone
                };

                using (var dados = new AcessoDados<Contato>())
                {
                    dados.Insert(contato);
                    this.Lista = dados.Listar();
                }
            });
        }
    }
}
