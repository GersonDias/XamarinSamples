using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;
using Xamarin.Forms;


[assembly: Dependency(typeof(DBApp.Droid.Config))]
namespace DBApp.Droid
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
                    _path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
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
                {
                    _plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }

                return _plataforma;
            }
        }
    }
}