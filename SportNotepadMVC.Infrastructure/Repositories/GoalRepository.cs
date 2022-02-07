using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{
    public class GoalRepository : IGoalRepository
    {
        private readonly Context _context;
        public GoalRepository(Context context)
        {
            _context = context;
        }
        public int AddGoal(Goal goal)
        {
            _context.Goals.Add(goal);
            _context.SaveChanges();
            return goal.Id;
        }

        public void DeleteGoal(int id)
        {
            var goal = _context.Goals.Find(id);
            if(goal != null)
            {
                _context.Goals.Remove(goal);
                _context.SaveChanges();
            }
        }

        public void EditGoal(Goal goal)
        {
            _context.Attach(goal);
            _context.Entry(goal).Property("Date").IsModified = true;
            _context.Entry(goal).Property("Name").IsModified = true;
            _context.Entry(goal).Property("Distance").IsModified = true;
            _context.Entry(goal).Property("Time").IsModified = true;
            _context.Entry(goal).Property("Location").IsModified = true;
            _context.Entry(goal).Property("Paid").IsModified = true;
            _context.Entry(goal).Property("Comment").IsModified = true;
            _context.SaveChanges();
        }

        public IQueryable<Goal> GetAllGoals()
        {
            return _context.Goals.Where(p => true);
        }

        public Goal GetGoalById(int idGoal)
        {
            return _context.Goals.FirstOrDefault(p => p.Id == idGoal);
        }
    }
}
