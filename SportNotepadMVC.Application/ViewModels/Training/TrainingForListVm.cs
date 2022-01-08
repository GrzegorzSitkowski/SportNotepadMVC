using AutoMapper;
using SportNotepadMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.Training
{
    public class TrainingForListVm : IMapFrom<Domain.Model.Training>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Distance { get; set; }
        public string Result { get; set; }
        public string AveragePace { get; set; }
        public void Mapper(Profile profile)
        {
            profile.CreateMap<Domain.Model.Training, TrainingForListVm>();
        }
    }
}
