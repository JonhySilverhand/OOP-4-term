using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public Format Format { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Превышение значение размера")]
        public int Size { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 50")]
        public string Name { get; set; }
        [UDC]
        public string UDC { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Значение числа страниц от 1 до 1000 ")]
        public int NumOfPages { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
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