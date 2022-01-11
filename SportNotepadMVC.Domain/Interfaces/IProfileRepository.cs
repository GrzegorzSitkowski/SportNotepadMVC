using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Interfaces
{
    public interface IProfileRepository
    {
        int FillProfile(Profile profile);
        void EditProfile(Profile profile);

    }
}
