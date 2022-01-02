using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Model
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Distance { get; set; }
        public string Result { get; set; }
        public string AveragePace { get; set; }
        public string Localization { get; set; }
        public string Comment { get; set; }
    }
}
