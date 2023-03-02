using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable]
    public enum Format
    {
        PDF,
        TXT,
        FB2,
        EPUB
    }
    public class FileBook
    {
        public Format Format { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public string UDC { get; set; }
        public int NumOfPages { get; set; }
        public int Year { get; set; }
        public Author Authors { get; set; }

        public FileBook(Format format, int size, string name, string udc, int numofpages, int year, string FIO, string Country, int ID)
        {
            Format = format;
            Size = size;
            Name = name;
            UDC = udc;
            NumOfPages = numofpages;
            Year = year;
            Authors = new Author(FIO, Country, ID);
        }

        public override string ToString()
        {
            return $"Format: {Format}, Size: {Size}, Name: {Name}, UDC: {UDC},\n Year: {Year}, NumOfPages: {NumOfPages}";
        }
    }
}