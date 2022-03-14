using AutoMapper;
using Microsoft.AspNetCore.Http;
using SportNotepadMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.PhotoGallery
{
    public class PhotoGalleryVm : IMapFrom<Domain.Model.PhotoGallery>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public IFormFile Path { get; set; }

        public void Mapping(Profile profile)
        {
        //    profile.CreateMap<PhotoGalleryVm, Domain.Model.PhotoGallery>().ReverseMap()
         //       .ForMember(a => a.Path, a => a.Ignore());
        }
    }
}
