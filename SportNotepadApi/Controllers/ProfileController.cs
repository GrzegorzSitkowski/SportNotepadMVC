using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.ProfileUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileUserService _profileService;

        public ProfileController(IProfileUserService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("Profile")]
        public ActionResult GetProfile()
        {
            var result = _profileService.DisplayProfileUser();
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("Edit")]
        public ActionResult EditProfile(NewProfileUserVm profileVm)
        {
            _profileService.EditProfileUser(profileVm);
            return Ok();
        }
    }
}
