using SportNotepadMVC.Application.ViewModels.Goal;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Application.Interfaces
{
    public interface IGoalService
    {
        int AddGoal(NewGoalVm goal);
        void DeleteGoal(int id);
        NewGoalVm GoalForEdit(int id);
        void EditGoal(NewGoalVm model);
        GoalDetailsVm GetGoalDetails(int id);
        GoalForListVm GetAllGoal();
        Goal GetGoalById(int idGoal);
    }
}
