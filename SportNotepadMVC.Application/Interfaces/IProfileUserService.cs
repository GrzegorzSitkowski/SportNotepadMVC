using SportNotepadMVC.Application.ViewModels.ProfileUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Interfaces
{
    public interface IProfileUserService
    {
        int FillProfileUser(NewProfileUserVm profileUser);
        void EditProfileUser(NewProfileUserVm model);
        ProfileUserDisplayVm DisplayProfileUser();
    }
}
