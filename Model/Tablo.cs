using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Model
{
    public class Tablo
    {
        public int Id { get; set; }
        public string Musteri { get; set; }
        public string Urun { get; set; }
        public int Tutar { get; set; }
        public string Tarih { get; set; }
    }
}