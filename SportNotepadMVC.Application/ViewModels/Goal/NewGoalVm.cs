using AutoMapper;
using SportNotepadMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.Goal
{
    public class NewGoalVm : IMapFrom<Domain.Model.Goal>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public bool Paid { get; set; }
        public string Comment { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewGoalVm, Domain.Model.Goal>().ReverseMap();
        }
    }
}
