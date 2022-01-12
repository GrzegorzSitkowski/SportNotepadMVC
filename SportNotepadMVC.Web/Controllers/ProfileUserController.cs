using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.ProfileUser;
using SportNotepadMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadMVC.Web.Controllers
{
    public class ProfileUserController : Controller
    {
        private readonly Context _context;
        private readonly IProfileUserService _profileUserService;

        public ProfileUserController(Context context, IProfileUserService profileUserService)
        {
            _context = context;
            _profileUserService = profileUserService;
        }

        public ActionResult Details()
        {
            var model = _profileUserService.DisplayProfileUser();
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var profileUser = _profileUserService.ProfileUserForEdit();
            return View(profileUser);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(NewProfileUserVm model)
        {
            _profileUserService.EditProfileUser(model);
            return RedirectToAction("Details");
        }
    }
}
