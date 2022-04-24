using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Competition;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly ICompetitionService _competitionService;

        public CompetitionController(ICompetitionService competitionService)
        {
            _competitionService = competitionService;
        }

        [HttpGet("Competitions")]
        public ActionResult<ListCompetitionForListVm> GetAllCompetitions()
        {
            var competitions = _competitionService.GetAllCompetitions();
            if (competitions.Competitions.Count == 0)
            {
                return NoContent();
            }
            return Ok(competitions);
        }

        [HttpGet("{id}")]
        public ActionResult GetCompetitionById(int id)
        {
            var result = _competitionService.GetCompetitionById(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("New")]
        public IActionResult AddCompetition([FromBody]NewCompetitionVm competitionVm)
        {
            if(!ModelState.IsValid || competitionVm.Id !=0 )
            {
                return Conflict(ModelState);
            }
            _competitionService.AddCopmetition(competitionVm);
            return Ok();
        }

        [HttpGet("Edit/{id}")]
        public IActionResult EditCompetition([FromBody]NewCompetitionVm competitionVm)
        {
            if(!ModelState.IsValid || competitionVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            _competitionService.EditCompetition(competitionVm);
            return Ok();
        }

        [HttpGet("Details/{id}")]
        public ActionResult<CompetitionDetailsVm> GetDetailsCompetition(int id)
        {
            var result = _competitionService.GetCompetitionDetails(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
