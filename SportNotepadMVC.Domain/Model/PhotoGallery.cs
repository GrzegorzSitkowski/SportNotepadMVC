using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Model
{
    public class PhotoGallery
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public List<IFormFile> filePhoto { get; set; }
    }
}
