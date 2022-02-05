using AutoMapper;
using SportNotepadMVC.Application.Interfaces;
using SportNotepadMVC.Application.ViewModels.Goal;
using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Services
{
    public class GoalService : IGoalService
    {
        private readonly IGoalRepository _goalRepo;
        private readonly IMapper _mapper;

        public GoalService(IGoalRepository goalRepo, IMapper mapper)
        {
            _goalRepo = goalRepo;
            _mapper = mapper;
        }

        public int AddGoal(NewGoalVm goal)
        {
            var _goal = _mapper.Map<Goal>(goal);
            var id = _goalRepo.AddGoal(_goal);
            return id;
        }

        public void DeleteGoal(int id)
        {
            _goalRepo.DeleteGoal(id);
        }

        public void EditGoal(NewGoalVm model)
        {
            var goal = _mapper.Map<Goal>(model);
            _goalRepo.EditGoal(goal);
        }

        public GoalForListVm GetAllGoal()
        {
            var goals = _goalRepo.GetAllGoals();
            var goalsVm = _mapper.Map<GoalForListVm>(goals);
            return goalsVm;
        }

        public Goal GetGoalById(int idGoal)
        {
            return _goalRepo.GetGoalById(idGoal);
        }

        public GoalDetailsVm GetGoalDetails(int id)
        {
            var goal = _goalRepo.GetGoalById(id);
            var goalVm = _mapper.Map<GoalDetailsVm>(goal);
            return goalVm;
        }

        public NewGoalVm GoalForEdit(int id)
        {
            var goal = _goalRepo.GetGoalById(id);
            var goalVm = _mapper.Map<NewGoalVm>(goal);
            return goalVm;
        }
    }
}
