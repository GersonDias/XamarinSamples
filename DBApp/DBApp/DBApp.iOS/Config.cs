using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(DBApp.iOS.Config))]

namespace DBApp.iOS
{
    public class Config : IConfig
    {
        private string _path;
        public string Path
        {
            get
            {
                if (string.IsNullOrEmpty(_path))
                {
                    var diretorio = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _path = System.IO.Path.Combine(diretorio, "..", "Library");
                }

                return _path;
            }
        }

        private ISQLitePlatform _plataforma;
        public ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                    _plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();

                return _plataforma;
            }
        }
    }
}
