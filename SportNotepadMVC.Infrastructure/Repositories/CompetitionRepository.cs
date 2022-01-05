using SportNotepadMVC.Domain.Interfaces;
using SportNotepadMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNotepadMVC.Infrastructure.Repositories
{
    public class CompetitionRepository : ICompetitionRepository
    {
        private readonly Context _context;
        public CompetitionRepository(Context context)
        {
            _context = context;
        }
        public int AddCompetition(Competition competition)
        {
            _context.Competitions.Add(competition);
            _context.SaveChanges();
            return competition.Id;
        }

        public void DeleteCompetition(int id)
        {
            var competition = _context.Competitions.Find(id);
            if (competition != null)
            {
                _context.Competitions.Remove(competition);
                _context.SaveChanges();
            }                     
        }

        public void EditCompetition(Competition competition)
        {
            _context.Attach(competition);
            _context.Entry(competition).Property("Position").IsModified = true;
            _context.Entry(competition).Property("Result").IsModified = true;
            _context.Entry(competition).Property("Name").IsModified = true;
            _context.Entry(competition).Property("City").IsModified = true;
            _context.Entry(competition).Property("Country").IsModified = true;
            _context.Entry(competition).Property("Distance").IsModified = true;
            _context.Entry(competition).Property("Date").IsModified = true;
            _context.Entry(competition).Property("Comment").IsModified = true;
            _context.SaveChanges();
        }

        public IQueryable<Competition> GetAllCompetitions()
        {
            return _context.Competitions.Where(p => true);
        }

        public Competition GetCompetitionById(int competitionId)
        {
            return _context.Competitions.FirstOrDefault(p => p.Id == competitionId);
        }
    }
}
