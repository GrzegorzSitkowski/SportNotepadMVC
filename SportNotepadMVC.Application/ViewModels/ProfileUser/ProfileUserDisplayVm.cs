using AutoMapper;
using Microsoft.AspNetCore.Http;
using SportNotepadMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.ProfileUser
{
    public class ProfileUserDisplayVm : IMapFrom<Domain.Model.ProfileUser>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Weight { get; set; }
        public string Pb5k { get; set; }
        public string Pb10k { get; set; }
        public string PbHalfMarathon { get; set; }
        public string PbMarathon { get; set; }
        public int CountCompetitions { get; set; }
        public IFormFile ProfilePicture { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Model.ProfileUser, ProfileUserDisplayVm>()
                .ForMember(a => a.ProfilePicture, a => a.Ignore());
        }
    }
}
