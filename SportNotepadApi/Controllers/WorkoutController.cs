using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.Services;
using SportNotepadMVC.Application.ViewModels.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportNotepadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly ITrainingService _trainingService;

        public WorkoutController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }

        [HttpGet("Workouts")]
        public ActionResult<ListTrainingForListVm> GetAllWorkouts()
        {
            var workouts = _trainingService.GetAllTrainigs();
            if (workouts.Trainings.Count == 0)
            {
                return NoContent();
            }
            return Ok(workouts);
        }

        [HttpGet("{id}")]
        public ActionResult GetWorkoutsbyId(int id)
        {
            var result = _trainingService.GetTrainingById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("New")]
        public IActionResult AddWorkouts([FromBody] NewTrainingVm trainigVm)
        {
            if (!ModelState.IsValid || trainigVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            return Ok();
        }

        [HttpGet("Edit/{id}")]
        public IActionResult EditWorkout([FromBody] NewTrainingVm trainingVm)
        {
            if (!ModelState.IsValid || trainingVm.Id != 0)
            {
                return Conflict(ModelState);
            }
            _trainingService.EditTraining(trainingVm);
            return Ok();
        }

        [HttpGet("Details/{id}")]
        public ActionResult<TrainingDetailsVm> GetDetailsWorkout(int id)
        {
            var result = _trainingService.GetTrainingDetails(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
