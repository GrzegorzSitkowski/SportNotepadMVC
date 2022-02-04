using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Domain.Interfaces
{
    public interface IGoalRepository
    {
        int AddGoal(Goal goal);
        void EditGoal(Goal goal);
        void DeleteGoal(int id);
        Goal GetGoalById(int idGoal);
        IQueryable<Goal> GetAllGoals();
    }
}
