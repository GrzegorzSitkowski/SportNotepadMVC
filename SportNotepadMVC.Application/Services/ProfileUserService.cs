﻿using AutoMapper;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.ProfileUser;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void EditProfileUser(NewProfileUserVm model)
        {
            var profileUser = _mapper.Map<ProfileUser>(model);
            _profileUserRepo.EditProfile(profileUser);
        }

        public int FillProfileUser(NewProfileUserVm profileUser)
        {
            var profileUs = _mapper.Map<ProfileUser>(profileUser);
            var id = _profileUserRepo.FillProfile(profileUs);
            return id;
        }
    }
}
