using AutoMapper;
using Microsoft.AspNetCore.Http;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.ProfileUser;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Services
{
    public class ProfileUserService : IProfileUserService
    {
        private readonly IMapper _mapper;
        private readonly IProfileUserRepository _profileUserRepo;

        public ProfileUserService(IMapper mapper, IProfileUserRepository profileUserRepo)
        {
            _mapper = mapper;
            _profileUserRepo = profileUserRepo;
        }
        public ProfileUserDisplayVm DisplayProfileUser()
        {
            var profileUser = _profileUserRepo.GetProfileUser();

            var profileUserVm = _mapper.Map<ProfileUserDisplayVm>(profileUser);
            return profileUserVm;
        }

        public void EditProfileUser(NewProfileUserVm model)
        {           
            var profileUser = _mapper.Map<ProfileUser>(model);
            _profileUserRepo.EditProfile(profileUser);
        }

        public NewProfileUserVm ProfileUserForEdit()
        {
            var profileUser = _profileUserRepo.GetProfileUser();
            var profileUserVm = _mapper.Map<NewProfileUserVm>(profileUser);
            return profileUserVm;
        }
    }
}
