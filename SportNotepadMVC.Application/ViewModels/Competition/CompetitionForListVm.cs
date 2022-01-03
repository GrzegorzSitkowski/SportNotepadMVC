using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.Competition
{
    public class CompetitionForListVm
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Result { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public float Distance { get; set; }
        public DateTime Date { get; set; }
    }
}
