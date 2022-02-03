using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{
    public class PhotoGalleryRepository : IPhotoGalleryRepository
    {
        private readonly Context _context;

        public PhotoGalleryRepository(Context context)
        {
            _context = context;
        }

        public int AddPhoto(PhotoGallery photoGallery)
        {
            _context.PhotoGalleries.Add(photoGallery);
            _context.SaveChanges();
            return photoGallery.Id;
        }

        public void DeletePhoto(int id)
        {
            var photoGallery = _context.PhotoGalleries.Find(id);
            if(photoGallery != null)
            {
                _context.PhotoGalleries.Remove(photoGallery);
                _context.SaveChanges();
            }
        }

        public void EditPhoto(PhotoGallery photoGallery)
        {
            _context.Attach(photoGallery);
            _context.Entry(photoGallery).Property("Title").IsModified = true;
            _context.Entry(photoGallery).Property("Name").IsModified = true;
            _context.SaveChanges();
        }

        public IQueryable<PhotoGallery> GetAllPhotos()
        {
            return _context.PhotoGalleries.Where(p => true);
        }

        public PhotoGallery GetPhotoById(int idPhoto)
        {
            return _context.PhotoGalleries.FirstOrDefault(p => p.Id == idPhoto);
        }
    }
}
