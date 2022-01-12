using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Interfaces
{
    public interface IProfileUserRepository
    {
        int FillProfile(ProfileUser profileUser);
        void EditProfile(ProfileUser profileUser);
        ProfileUser GetProfileUser();
    }
}
