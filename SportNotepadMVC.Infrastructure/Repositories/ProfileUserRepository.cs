using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{
    public class ProfileUserRepository : IProfileUserRepository
    {
        private readonly Context _context;

        public ProfileUserRepository(Context context)
        {
            _context = context;
        }

        /*public int FillProfile(ProfileUser profileUser)
        {
            _context.ProfileUsers.Add(profileUser);
            _context.SaveChanges();
            return profileUser.Id;
        }*/

        public void EditProfile(ProfileUser profileUser)
        {
            _context.ProfileUsers.Attach(profileUser);
            _context.Entry(profileUser).Property("FullName").IsModified = true;
            _context.Entry(profileUser).Property("Age").IsModified = true;
            _context.Entry(profileUser).Property("Weight").IsModified = true;
            _context.Entry(profileUser).Property("Pb5k").IsModified = true;
            _context.Entry(profileUser).Property("Pb10k").IsModified = true;
            _context.Entry(profileUser).Property("PbHalfMarathon").IsModified = true;
            _context.Entry(profileUser).Property("PbMarathon").IsModified = true;
            _context.Entry(profileUser).Property("CountCompetitions").IsModified = true;
            _context.SaveChanges();
        }

        public ProfileUser GetProfileUser()
        {
            return _context.ProfileUsers.FirstOrDefault();
        }
    }
}
