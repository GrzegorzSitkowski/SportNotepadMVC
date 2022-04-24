using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Goal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalController : ControllerBase
    {
        private readonly IGoalService _goalService;

        public GoalController(IGoalService goalService)
        {
            _goalService = goalService;
        }

        [HttpGet("Goals")]
        public ActionResult<ListGoalForListVm> GetAllGoals()
        {
            var goals = _goalService.GetAllGoal();
            if (goals.Goals.Count == 0)
            {
                return NoContent();
            }
            return Ok(goals);
        }

        [HttpGet("{id}")]
        public ActionResult GetGoalbyId(int id)
        {
            var result = _goalService.GetGoalById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("New")]
        public IActionResult AddGoal([FromBody] NewGoalVm goalVm)
        {
            if (!ModelState.IsValid || goalVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            return Ok();
        }

        [HttpGet("Edit/{id}")]
        public IActionResult EditGoal([FromBody] NewGoalVm goalVm)
        {
            if (!ModelState.IsValid || goalVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            _goalService.EditGoal(goalVm);
            return Ok();
        }

        [HttpGet("Details/{id}")]
        public ActionResult<GoalDetailsVm> GetDetailsGoal(int id)
        {
            var result = _goalService.GetGoalDetails(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
