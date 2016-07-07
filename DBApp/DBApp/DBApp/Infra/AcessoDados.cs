using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite.Net;
using DBApp.Model;

namespace DBApp.Infra
{
    public class AcessoDados<T> : IDisposable where T : Entity
    {
        private SQLiteConnection _connection;

        public AcessoDados()
        {
            var config = DependencyService.Get<IConfig>();
            _connection = new SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.Path, "bancodedados.db3"));

            _connection.CreateTable<T>();
        }

        public void Insert(T entity)
        {
            _connection.Insert(entity);
        }

        public void Update(T entity)
        {
            _connection.Update(entity);
        }

        public void Delete(T entity)
        {
            _connection.Delete(entity);
        }

        public T Obter(int id)
        {
            return _connection.Table<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> Listar()
        {
            return _connection.Table<T>().OrderBy(x => x.Id).ToList();
        }
        

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}
