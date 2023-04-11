using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Author
    {
        public string FIO { get; set; }
        public string Country { get; set; }
        public int ID { get; set; }
        public Author(string fio, string country, int id)
        {
            FIO = fio;
            Country = country;
            ID = id;
        }
        public override string ToString()
        {
            return $"ФИО: {FIO}, Страна: {Country}, ID: {ID}";
        }
    }
}
