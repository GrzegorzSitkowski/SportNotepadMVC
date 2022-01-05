using AutoMapper;
using SportNotepadMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.Competition
{
    public class NewCompetitionVm : IMapFrom<SportNotepadMVC.Domain.Model.Competition>
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Result { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public float Distance { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCompetitionVm, Domain.Model.Competition>().ReverseMap();
        }
    }
}
