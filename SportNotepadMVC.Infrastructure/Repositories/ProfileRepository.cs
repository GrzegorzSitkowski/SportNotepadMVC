using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly Context _context;

        public ProfileRepository(Context context)
        {
            _context = context;
        }

        public int FillProfile(Profile profile)
        {
            _context.Profiles.Add(profile);
            _context.SaveChanges();
            return profile.Id;
        }

        public void EditProfile(Profile profile)
        {
            _context.Profiles.Attach(profile);
            _context.Entry(profile).Property("FullName").IsModified = true;
            _context.Entry(profile).Property("Age").IsModified = true;
            _context.Entry(profile).Property("Weight").IsModified = true;
            _context.Entry(profile).Property("Pb5k").IsModified = true;
            _context.Entry(profile).Property("Pb10k").IsModified = true;
            _context.Entry(profile).Property("PbHalfMarathon").IsModified = true;
            _context.Entry(profile).Property("PbMarathon").IsModified = true;
            _context.Entry(profile).Property("CountCompetitions").IsModified = true;
            _context.SaveChanges();
        }      
    }
}
