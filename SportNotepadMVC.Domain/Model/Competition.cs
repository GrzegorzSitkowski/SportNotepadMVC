using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Model
{
    public class Competition
    {
        public int Id { get; set; }
        public string StartNumber { get; set; }
        public int Position { get; set; }
        public string Result { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Distance { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
