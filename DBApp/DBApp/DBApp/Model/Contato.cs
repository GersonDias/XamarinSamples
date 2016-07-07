using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace DBApp.Model
{
    public class Contato : Entity
    {
        public string Name { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }
        
        public override string ToString()
        {
            return $"{Name} - {Telefone} - {Environment.NewLine}{Email}";
        }
    }
}
