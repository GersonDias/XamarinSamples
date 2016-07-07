using SQLite.Net.Attributes;

namespace DBApp.Model
{
    public class Entity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
    }
}