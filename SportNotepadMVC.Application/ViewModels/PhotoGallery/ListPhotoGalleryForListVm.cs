using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.ViewModels.PhotoGallery
{
    public class ListPhotoGalleryForListVm
    {
        public PhotoGalleryVm photoGallery { get; set; }
        public List<PhotoGalleryVm> photoList { get; set; }
    }
}
