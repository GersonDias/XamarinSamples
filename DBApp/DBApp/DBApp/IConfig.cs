using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;

namespace DBApp
{
    public interface IConfig
    {
        string Path { get; }

        ISQLitePlatform Plataforma { get; }
    }
}
